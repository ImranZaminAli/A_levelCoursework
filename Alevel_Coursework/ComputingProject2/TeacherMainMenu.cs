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
    public partial class TeacherMainMenu : Form
    {
        Teacher _teacher;
        public TeacherMainMenu(Teacher teacher)
        {
            InitializeComponent();

            _teacher = teacher;

            int originalWidth = WelcomeMsgTxt.Size.Width;

            WelcomeMsgTxt.Text = "Welcome " + _teacher.FirstName;

            WelcomeMsgTxt.Location = new Point((WelcomeMsgTxt.Location.X + originalWidth - WelcomeMsgTxt.Size.Width) / 2, WelcomeMsgTxt.Location.Y); // readjusting welcome message based on size on length of name
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            new CreateSetForm(_teacher).Show();
            this.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            new EditSetForm(_teacher).Show();
            this.Close();
        }

        private void ManageBtn_Click(object sender, EventArgs e)
        {
            new MngeStudentsForm(_teacher).Show();
            this.Close();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            new WelcomeForm().Show();
            this.Close();
        }
    }
}