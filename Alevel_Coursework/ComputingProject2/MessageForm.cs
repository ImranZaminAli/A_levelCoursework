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

    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        public MessageForm(string msg) : this()
        {
            Size originalMsgSize = Msg.Size;
            Msg.Text = msg;
            this.Size = new Size(this.Size.Width + Msg.Size.Width - originalMsgSize.Width, this.Size.Height + Msg.Size.Height - originalMsgSize.Height); // adjusting location of message and button on window so that they
            Close.Location = new Point(Close.Location.X + (Msg.Size.Width - originalMsgSize.Width)/2 , Close.Location.Y + Msg.Size.Height - originalMsgSize.Height); // are in the right place based on the size of the message
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
