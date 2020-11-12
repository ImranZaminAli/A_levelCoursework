using System;
using System.Collections;
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
    public partial class ReviseForm : Form
    {
        private Student _student;
        private Set _set;
        private bool _first;
        private int _pointer;
        

        public ReviseForm(Student student, Set set, bool first) // first represent which side of the flashcard is shown initially
        {
            InitializeComponent();

            _student = student;
            _set = set;
            _first = first;
            _pointer = 0;
            
            DisplayTxt();
        }

        public void DisplayTxt()
        {
            if (_first)
            {
                CardTxt.Text = _set.Flashcards[_pointer].text1;
            }
            else
            {
                CardTxt.Text = _set.Flashcards[_pointer].text2;
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new LearnForm(_student).Show();
            this.Close();
        }

        private void FlipBtn_Click(object sender, EventArgs e)
        {
            _first = !_first;
            DisplayTxt();
        }

        private void ForwardsBtn_Click(object sender, EventArgs e)
        {
            _pointer = (_pointer + 1) % _set.Flashcards.Length; // wraps around
            DisplayTxt();
        }

        private void BackwardsBtn_Click(object sender, EventArgs e)
        {
            _pointer = _pointer == 0 ? _set.Flashcards.Length - 1 : _pointer - 1; // if at the beginning it will wrap around to the end
            DisplayTxt();
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            _set.UpdateNextReview(_student.Id);
            new LearnForm(_student).Show();
            this.Close();
        }
    }
}
