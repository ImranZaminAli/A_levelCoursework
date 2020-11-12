using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputingProject2
{
    public partial class WelcomeForm : Form
    {

        public WelcomeForm()
        {
            InitializeComponent();
            GDrive drive = new GDrive();
            
            drive.DownloadDatabase();

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }
    }
}
