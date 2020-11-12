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
    public partial class ConnForm : Form
    {
        private Student _student;
        public ConnForm(Student student)
        {
            InitializeComponent();
            _student = student;
            IdTxt.Text = "Your Id: " + _student.Id;
        }

        private void SndReqBtn_Click(object sender, EventArgs e)
        {
            new SndReqForm(_student).Show();
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new StudentMainMenu(_student).Show();
            this.Close();
        }

        private void ConnTeachBtn_Click(object sender, EventArgs e)
        {
            new TeacherConn(_student).Show();
            this.Close();
        }

        private void ViewReqBtn_Click(object sender, EventArgs e)
        {
            new ViewReqForm(_student).Show();
            this.Close();
        }

        private void RemoveConnBtn_Click(object sender, EventArgs e)
        {
            new RemoveConnForm(_student).Show();
            this.Close();
        }
    }
}
