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
    public partial class RemoveStudentForm : Form
    {
        private Teacher _teacher;
        private Querey _querey;

        public RemoveStudentForm(Teacher teacher)
        {
            InitializeComponent();

            _teacher = teacher;
            _querey = new Querey();

            using (_querey.connection = _querey.NewConn) // setting up dropdown menu
            {
                using (_querey.command = _querey.NewComm)
                {
                    _querey.command.CommandText = "SELECT StudentId, Firstname, Secondname FROM TeacherStudent, Users WHERE StudentId = Users.Id AND TeacherId = @id ORDER BY Users.Id ASC;";
                    _querey.AddParameter("@id", _teacher.Id);

                    using (_querey.reader = _querey.command.ExecuteReader())
                    {
                        while(_querey.reader.Read())
                        {
                            int id = _querey.reader.GetInt32(0);
                            string name = _querey.reader.GetString(1) + " " + _querey.reader.GetString(2);
                            Students.Items.Add(id + " : " + name);
                        }
                    }
                }
            }

            DeleteBtn.Enabled = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new MngeStudentsForm(_teacher).Show();
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int studentId;
            int length = Students.Text.IndexOf(" ");
            studentId = int.Parse(Students.Text.Substring(0, length));

            using (_querey.connection = _querey.NewConn)
            {
                using (_querey.command = _querey.NewComm)
                {
                    _querey.command.CommandText = "DELETE FROM TeacherStudent WHERE TeacherId = @teacher AND StudentId = @student;";
                    _querey.AddParameter("@teacher", _teacher.Id);
                    _querey.AddParameter("@student", studentId);

                    _querey.command.ExecuteNonQuery();
                }

                List<int> sets = new List<int> { };

                using (_querey.command = _querey.NewComm)
                {
                    _querey.command.CommandText = "SELECT Id FROM Sets WHERE OwnerId = @id;";
                    _querey.AddParameter("@id", _teacher.Id);
                    using (_querey.reader = _querey.command.ExecuteReader())
                    {
                        while (_querey.reader.Read())
                        {
                            sets.Add(_querey.reader.GetInt32(0));
                        }
                    }
                }

                foreach (int set in sets)
                {
                    string[] tables = { "Permissions", "SetProgress" };
                    foreach (string table in tables)
                    {
                        using (_querey.command = _querey.NewComm)
                        {
                            _querey.command.CommandText = "DELETE FROM " + table + " WHERE SetId  = @setId AND UserId = @student;";
                            _querey.AddParameter("@setId", set);
                            _querey.AddParameter("@student", studentId);
                            _querey.command.ExecuteNonQuery();
                        }
                    }
                }
            }

            DeleteBtn.Enabled = false;
            new GDrive().DownloadDatabase();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            if (Students.Text == "")
            {
                new MessageForm("Please select a student from the drop down menu.").Show();
            }
            else
            {
                bool exists = false;
                foreach (string student in Students.Items)
                {
                    if (Students.Text == student)
                    {
                        exists = true;
                        break;
                    }
                }

                if (exists)
                {
                    DeleteBtn.Enabled = true;
                }
                else
                {
                    new MessageForm("This student is not connected to you").Show();
                }
            }
        }
    }
}