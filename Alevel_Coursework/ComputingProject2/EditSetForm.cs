using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputingProject2
{

    public partial class EditSetForm : Form
    {
        private Student _student;
        private Teacher _teacher;
        int userId;
        private Set[] _sets;
        PartialQueue queue;
        Flashcard currentCard;
        Set currentSet;

        public EditSetForm(Student student)
        {
            InitializeComponent();

            _student = student;
            userId = _student.Id;

            Initialise();
        }

        public EditSetForm(Teacher teacher)
        {
            InitializeComponent();

            _teacher = teacher;
            userId = _teacher.Id;

            Initialise();
        }

        public void Initialise() // written as a procedure so that I wouldn't need to write the same code out in both constructors
        {

            _sets = new Set[50];

            ChangeEdit(false);

            Querey getSets = new Querey();
            using (getSets.connection = getSets.NewConn)
            {
                using (getSets.command = getSets.NewComm)
                {
                    getSets.command.CommandText = "SELECT Sets.Id, Sets.SetName, Sets.Title1, Sets.Title2 FROM Sets, Users WHERE Sets.OwnerId = Users.Id AND Sets.OwnerId = @userId;";
                    getSets.AddParameter("@userId", userId);


                    using (getSets.reader = getSets.command.ExecuteReader())
                    {
                        int i = 0;
                        int setId = 0;
                        string setName = "";
                        string title1 = "";
                        string title2 = "";
                        while (getSets.reader.Read())
                        {
                            setId = getSets.reader.GetInt32(0);
                            setName = getSets.reader.GetString(1);
                            title1 = getSets.reader.GetString(2);
                            title2 = getSets.reader.GetString(3);

                            _sets[i] = new Set(setId, userId, setName, title1, title2);
                            ChooseSet.Items.Add(_sets[i].SetName);
                            i++;
                        }
                    }
                }
            }
        }



        private void SelectSetBtn_Click(object sender, EventArgs e)
        {
            if (ChooseSet.Text == "")
            {
                MessageForm errorForm = new MessageForm("Please choose a set to edit");
            }
            else
            {
                for (int i = 0; i < _sets.Length; i++) // linear search
                {
                    if (_sets[i].SetName == ChooseSet.Text)
                    {
                        currentSet = _sets[i];
                        queue = new PartialQueue(_sets[i], Text1, Text2);
                        Title1.Text = _sets[i].Title1;
                        Title2.Text = _sets[i].Title2;
                        currentCard = queue.Load();
                        break;
                    }
                }
                ChangeEdit(true);
                PointerVal.Text = "1";
            }
        }

        private void ForwardsBtn_Click(object sender, EventArgs e)
        {
            currentCard.text1 = Text1.Text; // temporarily saves changes till user goes off set or goes onto the main menu
            currentCard.text2 = Text2.Text;
            PointerVal.Text = queue.Forwards().ToString();
            currentCard = queue.Load(); // updating card displayed
        }

        private void BackwardsBtn_Click(object sender, EventArgs e)
        {
            currentCard.text1 = Text1.Text; // temporarily saves changes till user goes off set or goes onto the main menu
            currentCard.text2 = Text2.Text;
            PointerVal.Text = queue.Backwards().ToString();
            currentCard = queue.Load(); // updating card displayed
        }

        private void SaveCardsBtn_Click(object sender, EventArgs e)
        {
            currentCard.text1 = Text1.Text;
            currentCard.text2 = Text2.Text;
            Querey querey = new Querey();
            foreach (Flashcard card in currentSet.Flashcards)
            {
                using (querey.connection = querey.NewConn)
                {
                    using (querey.command = querey.NewComm)
                    {
                        querey.command.CommandText = "UPDATE Flashcards SET Text1 = @text1, Text2 = @text2 WHERE Flashcards.Id = @flashId;";
                        querey.AddParameter("@text1", currentCard.text1);
                        querey.AddParameter("@text2", currentCard.text2);
                        querey.AddParameter("@flashId", currentCard.id);

                        querey.command.ExecuteNonQuery();
                    }
                }
            }
            SaveChanges();
            new MessageForm("changes saved").Show();
        }

        private void ChangeSetArray() // updates indexing in array when a flashcard is added or removed from it.
        {
            int num = 0;

            do
            {
                if (queue.GetQueue[num] == null)
                {
                    break;
                }
                num++;
            } while (num < queue.GetQueue.Length-1);

            queue.GetQueue[num] = currentCard;
            currentSet.NewFlashcards(num);

            for (int i = 0; i < num; i++)
            {
                currentSet.Flashcards[i] = queue.GetQueue[i];
            }
        }

        private void NewCardBtn_Click(object sender, EventArgs e)
        {
            Querey querey = new Querey();

            if (CountFlashcards() == 64)
            {
                MessageForm errorForm = new MessageForm("You already have the maximum numbers of cards in this set.");
                errorForm.Show();
            }
            else
            {
                int flashId = 0;
                using (querey.connection = querey.NewConn)
                {
                    using (querey.command = querey.NewComm)
                    {
                        querey.command.CommandText = "INSERT INTO Flashcards (SetId, Text1, Text2) VALUES (@setId, @text1, @text2);";
                        querey.AddParameter("@setId", currentCard.setId);
                        querey.AddParameter("@text1", Text1.Text);
                        querey.AddParameter("@text2", Text2.Text);

                        querey.command.ExecuteNonQuery();
                    }

                    using (querey.command = querey.NewComm)
                    {
                        querey.command.CommandText = "SELECT Flashcards.Id FROM Flashcards WHERE SetId = @setId AND Text1 = @text1 AND Text2 = @text2;";
                        querey.AddParameter("@setId", currentCard.setId);
                        querey.AddParameter("@text1", Text1.Text);
                        querey.AddParameter("@text2", Text2.Text);

                        using (querey.reader = querey.command.ExecuteReader())
                        {
                            while (querey.reader.Read())
                            {
                                flashId = querey.reader.GetInt32(0);
                            }
                        }
                    }
                }
                SaveChanges();
                new MessageForm("insertion successful").Show();
                queue.Enqueue(new Flashcard(flashId, currentCard.setId, Text1.Text, Text2.Text));
                PointerVal.Text = queue.Forwards().ToString();
                currentCard = queue.Load();
                ChangeSetArray();
            }
        }

        private void DeleteCardBtn_Click(object sender, EventArgs e)
        {

            if (CountFlashcards() == 1)
            {
                MessageForm errorForm = new MessageForm("You cannot have an empty set.");
                errorForm.Show();
            }
            else
            {
                Querey querey = new Querey();
                using (querey.connection = querey.NewConn)
                {
                    using (querey.command = querey.NewComm)
                    {
                        querey.command.CommandText = "DELETE FROM Flashcards WHERE Flashcards.Id = @flashId;";
                        querey.AddParameter("@flashId", currentCard.id);

                        querey.command.ExecuteNonQuery();
                    }
                }

                SaveChanges();
                queue.Dequeue();
                ChangeSetArray();
                PointerVal.Text = queue.Backwards().ToString();
                currentCard = queue.Load();
                new MessageForm("deleted").Show();
            }
        }

        private int CountFlashcards()
        {
            int count = 0;
            Querey querey = new Querey();
            using (querey.connection = querey.NewConn)
            {
                using (querey.command = querey.NewComm)
                {
                    querey.command.CommandText = "SELECT count(SetId) FROM Flashcards WHERE SetId = @setid;";
                    querey.AddParameter("@setid", currentCard.setId);

                    querey.command.CommandType = CommandType.Text;
                    count = Convert.ToInt32(querey.command.ExecuteScalar());
                }
            }
            return count;
        }

        private void SaveTitleBtn_Click(object sender, EventArgs e)
        {
            Querey querey = new Querey();
            using (querey.connection = querey.NewConn)
            {
                using (querey.command = querey.NewComm)
                {
                    querey.command.CommandText = "UPDATE Sets SET Title1 = @title1, Title2 = @title2 WHERE Id = @id;";
                    querey.AddParameter("@title1", Title1.Text);
                    querey.AddParameter("@title2", Title2.Text);
                    querey.AddParameter("@id", currentCard.setId);

                    querey.command.ExecuteNonQuery();
                }
            }

            currentSet.Title1 = Title1.Text;
            currentSet.Title2 = Title2.Text;

            SaveChanges();
        }

        private void DeleteSetBtn_Click(object sender, EventArgs e)
        {
            ChooseSet.Text = "";
            ChooseSet.Items.Remove(currentSet.SetName);

            Text1.Clear();
            Text2.Clear();
            Title1.Clear();
            Title2.Clear();
            PointerInput.Clear();
            PointerVal.Text = "";

            Querey querey = new Querey();
            using (querey.connection = querey.NewConn)
            {
                string[][] tables = { new string[] { "Sets", "Id" }, new string[] { "Flashcards", "SetId" }, new string[] { "Permissions", "SetId" }, new string[] { "SetProgress", "SetId" } };

                foreach (string[] table in tables)
                {
                    using (querey.command = querey.NewComm)
                    {
                        querey.command.CommandText = "DELETE FROM " + table[0] + " WHERE " + table[1] + "= @setid;";
                        querey.AddParameter("@setid", currentCard.setId);
                        querey.command.ExecuteNonQuery();
                    }
                }
            }

            currentSet = null;

            ChangeEdit(false);
            SaveChanges();
            new MessageForm("deleted").Show();
        }

        private void ChangeEdit(bool change)
        {
            Text1.Enabled = change;
            Text2.Enabled = change;
            Title1.Enabled = change;
            Title2.Enabled = change;
            PointerVal.Enabled = change;
            PointerInput.Enabled = change;
            JumpBtn.Enabled = change;
            BackwardsBtn.Enabled = change;
            ForwardsBtn.Enabled = change;
            NewCardBtn.Enabled = change;
            SaveCardsBtn.Enabled = change;
            DeleteCardBtn.Enabled = change;
            SaveTitleBtn.Enabled = change;
            DeleteSetBtn.Enabled = change;
        }

        private void SaveChanges()
        {
            GDrive drive = new GDrive();
            drive.DeleteDriveDatabase();
            drive.UploadDatabase();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (_student == null)
            {
                new TeacherMainMenu(_teacher).Show();
            }
            else
            {
                new StudentMainMenu(_student).Show();
            }
            this.Close();
        }

        private void JumpBtn_Click(object sender, EventArgs e)
        {
            if (PointerInput.Text == "")
            {
                MessageForm errorForm = new MessageForm("Please enter which card you want to go to");
                errorForm.Show();
            }
            else if (int.Parse(PointerInput.Text) < 0 || int.Parse(PointerInput.Text) > queue.GetQueue.Length)
            {
                MessageForm errorForm = new MessageForm("Please enter a value within the range of your flashcards");
                errorForm.Show();
            }
            else if (queue.GetQueue[int.Parse(PointerInput.Text) - 1] == null)
            {
                MessageForm errorForm = new MessageForm("Your set does not have that many flashcards");
                errorForm.Show();
            }
            else
            {
                int difference = int.Parse(PointerVal.Text) - int.Parse(PointerInput.Text);
                bool back = false;
                if (difference < 0)
                {
                    difference = -difference;
                    back = true;
                }

                for (int i = 0; i < difference; i++)
                {
                    PointerVal.Text = (back ? queue.Forwards() : queue.Backwards()).ToString();
                }

                currentCard = queue.Load();
            }
            PointerInput.Clear();
        }
    }
}