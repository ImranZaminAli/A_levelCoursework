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
    public partial class StudentMainMenu : Form
    {
        private Student _student;

        public StudentMainMenu()
        {
            InitializeComponent();
        }

        public StudentMainMenu(Student student) : this()
        {
            _student = student;
            int originalWidth = TeacherConn.Size.Width; // adjust position of teacher connection label to make sure its in the right place
            if(_student.teacherConn == null)
            {
                TeacherConn.Text = "Your account is not linked to a teacher";
            }
            else
            {
                TeacherConn.Text = "Your account is linked to " + _student.teacherConn.Item2;
            }

            TeacherConn.Location = new Point(TeacherConn.Location.X + originalWidth - TeacherConn.Size.Width, TeacherConn.Location.Y);

            originalWidth = Welcome.Size.Width; // adjust position of welcome message label to make sure its in the right place
            Welcome.Text = "Welcome " + _student.FirstName;

            Welcome.Location = new Point((Welcome.Location.X + originalWidth - Welcome.Size.Width)/2, Welcome.Location.Y);
        }

        private void LearnBtn_Click(object sender, EventArgs e)
        {
            new LearnForm(_student).Show();
            this.Close();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Querey querey = new Querey();
            int count;
            using (querey.connection = querey.NewConn)
            {
                using (querey.command = querey.NewComm)
                {
                    querey.command.CommandText = "SELECT count(Sets.Id) FROM Sets WHERE Sets.OwnerId = @owner;";
                    querey.AddParameter("@owner", _student.Id);

                    querey.command.CommandType = CommandType.Text;
                    count = Convert.ToInt32(querey.command.ExecuteScalar());
                }
            }
            if (count == 50)
            {
                new MessageForm("You've created the maximum number of sets").Show();
            }
            else
            {
                new CreateSetForm(_student).Show();
                this.Close();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            new EditSetForm(_student).Show();
            this.Close();
        }

        private void ConnBtn_Click(object sender, EventArgs e)
        {
            new ConnForm(_student).Show();
            this.Close();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            new WelcomeForm().Show();
            this.Close();
        }
    }
}
