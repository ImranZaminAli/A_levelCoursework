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
    public partial class LearnForm : Form
    {
        private Student _student;
        private Querey _querey;
        private Set[] _sets;
        private Set chosenSet;
        private bool _first;
        int size;

        public LearnForm(Student student)
        {
            InitializeComponent();

            _student = student;
            _querey = new Querey();
            _first = true;
            int num = 0;

            using (_querey.connection = _querey.NewConn)
            {
                using (_querey.command = _querey.NewComm)
                {
                    _querey.command.CommandText = "SELECT Sum(i.count) FROM(SELECT count(*) AS COUNT FROM Permissions WHERE UserId = @user UNION ALL SELECT Count(*) AS COUNT FROM Sets WHERE OwnerId = @user) i; ";
                    _querey.AddParameter("@user", _student.Id);
                    _querey.command.CommandType = CommandType.Text;
                    size = Convert.ToInt32(_querey.command.ExecuteScalar());
                }
                _sets = new Set[size];

                using (_querey.command = _querey.NewComm)
                {
                    _querey.command.CommandText = "SELECT Sets.Id, Sets.OwnerId, Sets.SetName, Sets.Title1, Sets.Title2 FROM Sets WHERE Sets.OwnerId = @user;";
                    _querey.AddParameter("@user", _student.Id);

                    Read(ref num);
                }

                using (_querey.command = _querey.NewComm)
                {
                    _querey.command.CommandText = "SELECT Sets.Id, Sets.OwnerId, Sets.SetName, Sets.Title1, Sets.Title2 FROM Sets, Permissions WHERE Sets.Id = Permissions.SetId AND Permissions.UserId = @user;";
                    _querey.AddParameter("@user", _student.Id);
                    Read(ref num);
                }

            }

            QuickSort(_sets, 0, _sets.Length - 1);

            foreach (Set set in _sets)
            {
                double percent = Math.Round((1 - set.Urgency) * 100); // when showing to the user a larger percentage means a greater need to revise
                ChooseSet.Items.Add(set.SetName + " " + percent);
            }

            ReviseBtn.Enabled = false;
            TestBtn.Enabled = false;
            SwapBtn.Enabled = false;
            Titles.Enabled = false;
            Titles.Text = "";
        }

        private void Read(ref int num)
        {
            using (_querey.reader = _querey.command.ExecuteReader())
            {
                while (_querey.reader.Read())
                {
                    int setId = _querey.reader.GetInt32(0);
                    int ownerId = _querey.reader.GetInt32(1);
                    string setName = _querey.reader.GetString(2);
                    string title1 = _querey.reader.GetString(3);
                    string title2 = _querey.reader.GetString(4);
                    _sets[num] = new Set(setId, ownerId, setName, title1, title2);
                    _sets[num].CalculateUrgency(_student.Id);
                    num++;
                }
            }
        }

        private static void QuickSort(Set[] sets, int lowerBound, int upperBound)
        {
            if(lowerBound < upperBound)
            {
                int pivotPoint = Partition(sets, lowerBound, upperBound);

                QuickSort(sets, lowerBound, pivotPoint - 1); // divide and conquer
                QuickSort(sets, pivotPoint + 1, upperBound);
            }

        }

        private static int Partition(Set[] sets, int lowerBound, int upperBound)
        {
            int swapPointer = lowerBound; // more meaningfull names to help prevent errors
            int pivotPointer = upperBound;

            while (swapPointer != pivotPointer) // moving all values greater than the pointer to one side of the pointer in the array
            {
                if (sets[swapPointer].Urgency > sets[pivotPointer].Urgency)
                {
                    Set temp = sets[swapPointer];
                    sets[swapPointer] = sets[pivotPointer - 1];
                    sets[pivotPointer - 1] = sets[pivotPointer];
                    sets[pivotPointer] = temp;
                    pivotPointer--;
                }
                else
                {
                    swapPointer++;
                }
            }

            return pivotPointer;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new StudentMainMenu(_student).Show();
            this.Close();
        }

        private void ChooseSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwapBtn.Enabled = true;
            ReviseBtn.Enabled = true;
            TestBtn.Enabled = true;
            Titles.Enabled = true;

            DisplayTitleTxt();
        }

        private void SwapBtn_Click(object sender, EventArgs e)
        {
            _first = !_first;

            DisplayTitleTxt();
        }

        private void DisplayTitleTxt()
        {
            chosenSet = _sets[ChooseSet.Items.IndexOf(ChooseSet.Text)];

            if (_first)
            {
                Titles.Text = chosenSet.Title1 + " to " + chosenSet.Title2;
            }
            else
            {
                Titles.Text = chosenSet.Title2 + " to " + chosenSet.Title1;
            }
        }

        private void ReviseBtn_Click(object sender, EventArgs e)
        {
            new ReviseForm(_student, chosenSet, _first).Show();
            this.Close();
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            new TestForm(_student, chosenSet, _first).Show();
            this.Close();
        }

        
    }
}
