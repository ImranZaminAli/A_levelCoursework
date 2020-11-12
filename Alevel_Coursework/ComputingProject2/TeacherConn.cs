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
    public partial class TeacherConn : Form
    {
        private Student _student;
        Querey querey = new Querey();
        int teacherId;
        string teacherEmail;
        string teacherName;
        public TeacherConn(Student student)
        {
            InitializeComponent();
            TeachNameTxt.Text = "";
            ConfirmBtn.Enabled = false;
            _student = student;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new StudentMainMenu(_student).Show();
            this.Close();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            using (querey.connection = querey.NewConn)
            {
                using (querey.command = querey.NewComm)
                {
                    querey.command.CommandText = "SELECT Users.Id, Email, Firstname, Secondname FROM Users, Teacher WHERE Teacher.TeacherId = Users.Id AND Teacher.InviteKey = @key;";
                    querey.AddParameter("@key", KeyIn.Text);
                    using (querey.reader = querey.command.ExecuteReader())
                    {
                        if (querey.reader.Read())
                        {
                            teacherId = querey.reader.GetInt32(0);
                            teacherEmail = querey.reader.GetString(1);
                            teacherName = querey.reader.GetString(2);
                            TeachNameTxt.Text = querey.reader.GetString(2) + " " + querey.reader.GetString(3);
                            ConfirmBtn.Enabled = true;
                        }
                        else
                        {
                            new MessageForm("There is no teacher with this id.").Show();
                        }
                    }
                }
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            using (querey.connection = querey.NewConn)
            {
                using (querey.command = querey.NewComm)
                {
                    querey.command.CommandText = "INSERT INTO TeacherRequest (StudentId, TeacherId) VALUES (@student, @teacher);";
                    querey.AddParameter("@student", _student.Id);
                    querey.AddParameter("@teacher", teacherId);
                    querey.command.ExecuteNonQuery();
                }
            }

            new Email(teacherEmail, "Connection request", "Hello " + teacherName + ",\n\n" + _student.FirstName + "has sent a request to use your sets. Please log on to accept or decline this request.");

            TeachNameTxt.Text = "";
            ConfirmBtn.Enabled = false;
            KeyIn.Clear();
            new MessageForm("Request sent.").Show();
            new GDrive().UploadDatabase();
        }
    }
}
