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
    public partial class SndReqForm : Form
    {
        private Student _student;
        string recFirstName;
        string recEmail;
        Querey querey;

        public SndReqForm(Student student)
        {
            InitializeComponent();

            _student = student;
            IdTxt.Text = "Your Id :" + _student.Id;
            ConfirmBtn.Enabled = true;
            querey = new Querey();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            ConnForm connForm = new ConnForm(_student);
            connForm.Show();
            this.Close();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            if(RecIdIn.Text == "") // checks if something has been entered
            {
                new MessageForm("Please enter an id").Show();
            }
            else if(int.TryParse(RecIdIn.Text, out int receiverId)) // checks if numbers have been entered
            {
                using (querey.connection = querey.NewConn)
                {
                    bool exists = false;
                    using (querey.command = querey.NewComm)
                    {
                        querey.command.CommandText = "SELECT * FROM FriendRequest WHERE SenderId = @sender AND ReceiverId = @receiver OR SenderId = @receiver AND ReceiverId = @sender;";
                        SetParams();
                        using (querey.reader = querey.command.ExecuteReader())
                        {
                            exists = querey.reader.Read();
                        }
                    }
                    if (exists)
                    {
                        new MessageForm("A request already exists with both of you").Show();
                    }
                    else
                    {
                        using (querey.command = querey.NewComm)
                        {
                            querey.command.CommandText = querey.command.CommandText = "SELECT * FROM Friends WHERE Student1 = @sender AND Student2 = @receiver OR Student1 = @receiver AND Student2 = @sender;";
                            SetParams();
                            using (querey.reader = querey.command.ExecuteReader())
                            {
                                exists = querey.reader.Read();
                            }
                        }
                        if (exists)
                        {
                            new MessageForm("You are already friends.");
                        }
                        else
                        {
                            using (querey.command = querey.NewComm)
                            {
                                querey.command.CommandText = "SELECT Firstname, SecondName, Teacher,Id, Email FROM Users WHERE Id = @id;";
                                querey.AddParameter("@id", receiverId);
                                SetParams();
                                string name;
                                bool isStudent;
                                using (querey.reader = querey.command.ExecuteReader())
                                {
                                    if (querey.reader.Read())
                                    {
                                        if (querey.reader.GetInt32(3) == _student.Id)
                                        {
                                            new MessageForm("You cannot send a request to yourself").Show();
                                        }
                                        else
                                        {
                                            recFirstName = querey.reader.GetString(0);
                                            name = querey.reader.GetString(0) + " " + querey.reader.GetString(1);
                                            recEmail = querey.reader.GetString(4);
                                            isStudent = (querey.reader.GetString(2) != "1"); // the bool value equals true if the value read from the database is one. else it is false
                                            if (!isStudent)
                                            {
                                                new MessageForm("You can only send friend requests to other students").Show();
                                            }
                                            else
                                            {
                                                RecNameTxt.Text = "Send request to " + name;
                                                ConfirmBtn.Enabled = true;
                                            }
                                        }

                                    }
                                    else
                                    {
                                        new MessageForm("The id entered is invalid").Show();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                new MessageForm("User ids only consist of integers.").Show();
            }
        }
        
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            using (querey.connection = querey.NewConn)
            {
                using (querey.command = querey.NewComm)
                {
                    querey.command.CommandText = "INSERT INTO FriendRequest (SenderId, ReceiverId) VALUES (@sender, @receiver);";
                    SetParams();
                    querey.command.ExecuteNonQuery();
                }
            }

            new Email(recEmail, "Friend Request", "Hello " + recFirstName + ".\n\n" + _student.FirstName + " has sent you a friend request. Please login to accept or decline it.");


            RecIdIn.Clear();
            ConfirmBtn.Enabled = false;
            RecNameTxt.Text = "";
            new MessageForm("sent request").Show();
            new GDrive().UploadDatabase();
        }

        void SetParams()
        {
            querey.AddParameter("@sender", _student.Id);
            querey.AddParameter("@receiver", int.Parse(RecIdIn.Text));
        }
    }
}
