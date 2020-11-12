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
    public partial class MngeStudentsForm : Form
    {
        private Teacher _teacher;

        public MngeStudentsForm(Teacher teacher)
        {
            InitializeComponent();
            _teacher = teacher;
            KeyLbl.Text = _teacher.Key;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new TeacherMainMenu(_teacher).Show();
            this.Close();
        }

        private void RequestsBtn_Click(object sender, EventArgs e)
        {
            new ViewReqForm(_teacher).Show();
            this.Close();
        }

        private void CopyKeyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(KeyLbl.Text);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
           new RemoveStudentForm(_teacher).Show();
            this.Close();
        }
    }
}
