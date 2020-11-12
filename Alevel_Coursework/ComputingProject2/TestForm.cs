using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputingProject2
{
    public partial class TestForm : Form
    {
        private Student _student;
        private Set _set;
        private bool _first;
        private Hashtable hashTable;
        private int _index;

        public TestForm(Student student, Set set, bool first) // first represents which side of the flashcard is given to the user
        {
            InitializeComponent();

            _student = student;
            _set = set;
            _first = first;
            hashTable = new Hashtable();

            for (int i = 0; i < _set.Flashcards.Length; i++)
            {
                hashTable.Add(i, _set.Flashcards[i]);
            }

            DisplayCard();

            Prompt.ReadOnly = true;
            FinishBtn.Enabled = false;
            ChangeEdit(false);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new LearnForm(_student).Show();
            this.Close();
        }

        private void DisplayCard()
        {
            Prompt.Clear();
            Input.Clear();
            if (hashTable.Count != 0)
            {
                Random rnd = new Random();
                int max = _set.Flashcards.Length;
                bool found = false;
                do
                {
                    _index = rnd.Next(0, max);

                    if (hashTable.Contains(_index))
                    {
                        found = true;
                        Prompt.Text = _first ? _set.Flashcards[_index].text1 : _set.Flashcards[_index].text2;
                    }
                } while (!found);
            }
            else
            {
                FinishBtn.Enabled = true;
                Input.Enabled = false;
                SubmitBtn.Enabled = false;
                OverrideBtn.Enabled = false;
                NextBtn.Enabled = false;
                NotificationTxt.Text = "FINISHED!";
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string txt = _first ? _set.Flashcards[_index].text2 : _set.Flashcards[_index].text1;
            if (Input.Text == txt)
            {
                NotificationTxt.Text = "CORRECT!";
                Input.ForeColor = Color.Lime;
                hashTable.Remove(_index);
            }
            else
            {
                NotificationTxt.Text = "INCORRECT";
                Input.Text = txt;
                Input.ForeColor = Color.DarkRed;
            }

            ChangeEdit(true);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            Input.ForeColor = Color.Black;
            ChangeEdit(false);
            DisplayCard();

        }

        private void OverrideBtn_Click(object sender, EventArgs e)
        {
            Input.ForeColor = Color.Green;
            hashTable.Remove(_index);
        }

        private void ChangeEdit(bool change)
        {
            NextBtn.Enabled = change;
            SubmitBtn.Enabled = !change;
            OverrideBtn.Enabled = change;
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            _set.UpdateNextReview(_student.Id);
            new LearnForm(_student).Show();
            this.Close();
        }
    }
}
