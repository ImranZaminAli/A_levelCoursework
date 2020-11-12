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
    public partial class RemoveConnForm : Form // I have used different procedures for selecting and remvoing requests because, despite being similar, they have different queries and associated objects. 
    {                                          //To use one procedure for both parts would require a large number of if statements which would make the code harder to read, harder to follow and less elegent.
        private Student _student;
        private Querey querey;
        private List<Tuple<int,string>> items;
        public RemoveConnForm(Student student)
        {
            InitializeComponent();

            _student = student;
            querey = new Querey();

            using (querey.connection = querey.NewConn) // setting up drop down menu for deleting requests
            {
                using (querey.command = querey.NewComm)
                {
                    querey.command.CommandText = "SELECT FriendRequest.ReceiverId, Users.FirstName, Users.SecondName FROM FriendRequest, Users WHERE FriendRequest.ReceiverId = Users.Id AND FriendRequest.SenderId = @sender ORDER BY Users.Id ASC;";
                    querey.AddParameter("@sender", _student.Id);

                    using (querey.reader = querey.command.ExecuteReader())
                    {
                        while (querey.reader.Read())
                        {
                            int id = querey.reader.GetInt32(0);
                            string name = querey.reader.GetString(1) + " " + querey.reader.GetString(2);

                            SelectRequest.Items.Add(id + " : " + name);
                        }
                    }
                }

                using (querey.command = querey.NewComm) // setting up drop down menu for deleting friends
                {
                    querey.command.CommandText = "SELECT Users.Id, Users.Firstname, Users.Secondname FROM Friends,Users WHERE Users.Id = Student1 AND Student2 = @id OR Users.Id = Student2 AND Student1 = @id ORDER BY Users.Id ASC;";
                    querey.AddParameter("@id", _student.Id);
                    using (querey.reader = querey.command.ExecuteReader())
                    {
                        while (querey.reader.Read())
                        {
                            int id = querey.reader.GetInt32(0);
                            string name = querey.reader.GetString(1) + " " + querey.reader.GetString(2);
                            SelectFriend.Items.Add(id + " : " + name);
                        }
                    }
                }
            }
            DeleteRequestBtn.Enabled = false;
            DeleteFriendBtn.Enabled = false;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new ConnForm(_student).Show();
            this.Close();
        }

        private void DeleteRequestBtn_Click(object sender, EventArgs e)
        {
            using (querey.connection = querey.NewConn)
            {
                using (querey.command = querey.NewComm)
                {
                    querey.command.CommandText = "DELETE FROM FriendRequest WHERE SenderId = @sender AND ReceiverId = @receiver;";
                    querey.AddParameter("@sender", _student.Id);
                    int length = SelectRequest.Text.IndexOf(" ");
                    new MessageForm(SelectRequest.Text.Substring(0, length));
                    querey.AddParameter("@receiver", int.Parse(SelectRequest.Text.Substring(0, length)));

                    querey.command.ExecuteNonQuery();
                }
            }

            new MessageForm("Request deleted.").Show();

            new GDrive().UploadDatabase();

            SelectRequest.Text = "";
            DeleteRequestBtn.Enabled = false;
        }

        private void SelectRequestBtn_Click(object sender, EventArgs e)
        {
            if(SelectRequest.Text == "")
            {
                new MessageForm("Please select a request").Show();
            }
            else
            {
                bool exists = false;
                foreach(string request in SelectRequest.Items)
                {
                    if(SelectRequest.Text == request)
                    {
                        exists = true;
                        break;
                    }
                }

                if (exists)
                {
                    DeleteRequestBtn.Enabled = true;
                }
                else
                {
                    new MessageForm("You have not sent a request to this person").Show();
                }
            }
        }

        private void SelectFriendBtn_Click(object sender, EventArgs e)
        {
            if(SelectFriend.Text == "")
            {
                new MessageForm("Please select a friend.").Show();
            }
            else
            {
                bool exists = false;
                foreach (string friend in SelectFriend.Items)
                {
                    if (SelectFriend.Text == friend)
                    {
                        exists = true;
                        break;
                    }
                }

                if (exists)
                {
                    DeleteFriendBtn.Enabled = true;
                }
                else
                {
                    new MessageForm("You are not friends with this person").Show();
                }
            }
        }

        private void DeleteFriendBtn_Click(object sender, EventArgs e)
        {
            int friendId;
            int length = SelectFriend.Text.IndexOf(" ");
            friendId = int.Parse(SelectFriend.Text.Substring(0, length));
            using (querey.connection = querey.NewConn)
            {
                using (querey.command = querey.NewComm)
                {
                    querey.command.CommandText = "DELETE FROM Friends WHERE Student1 = @user AND Student2 = @friend OR Student1 = @friend AND Student2 = @user;";
                    querey.AddParameter("@user", _student.Id);
                    querey.AddParameter("@friend", friendId);

                    querey.command.ExecuteNonQuery();
                }

                List<int> sets = new List<int> { };

                using (querey.command = querey.NewComm)
                {
                    querey.command.CommandText = "SELECT Id FROM Sets WHERE OwnerId = @id;";
                    querey.AddParameter("@id", _student.Id);
                    using (querey.reader = querey.command.ExecuteReader())
                    {
                        while (querey.reader.Read())
                        {
                            sets.Add(querey.reader.GetInt32(0));
                        }
                    }
                }

                foreach (int set in sets)
                {
                    string[] tables = { "Permissions", "SetProgress" };
                    foreach (string table in tables)
                    {
                        using (querey.command = querey.NewComm)
                        {
                            querey.command.CommandText = "DELETE FROM " + table + " WHERE SetId  = @setId AND UserId = @friendId;";
                            querey.AddParameter("@setId", set);
                            querey.AddParameter("@friendId", friendId);
                            querey.command.ExecuteNonQuery();
                        }

                    }
                }

                sets.Clear();

                using (querey.command = querey.NewComm)
                {
                    querey.command.CommandText = "SELECT Id FROM Sets WHERE OwnerId = @friendId;";
                    querey.AddParameter("@friendId", friendId);
                    using (querey.reader = querey.command.ExecuteReader())
                    {
                        while (querey.reader.Read())
                        {
                            sets.Add(querey.reader.GetInt32(0));
                        }
                    }
                }

                foreach (int set in sets)
                {
                    string[] tables = { "Permissions", "SetProgress" };
                    foreach (string table in tables)
                    {
                        using (querey.command = querey.NewComm)
                        {
                            querey.command.CommandText = "DELETE FROM " + table + " WHERE SetId = @setId AND userId = @userId;";
                            querey.AddParameter("@setId", set);
                            querey.AddParameter("@userId", _student.Id);
                            querey.command.ExecuteNonQuery();
                        }
                    }
                }
            }

            new MessageForm("Friend deleted.").Show();
            new GDrive().UploadDatabase();

            string email;
            string name;
            using (querey.connection = querey.NewConn)
            {
                using (querey.command = querey.NewComm)
                {
                    querey.command.CommandText = "SELECT Email, Firstname FROM Users WHERE Id = @id";
                    querey.AddParameter("@id", friendId);

                    using (querey.reader = querey.command.ExecuteReader())
                    {
                        querey.reader.Read();
                        email = querey.reader.GetString(0);
                        name = querey.reader.GetString(1);
                    }
                }
            }

            new Email(email, "Friendships", "Hello " + name + ",\nWe are sorry to say this but " + _student.FirstName + "has removed you as a friend. You will no longer be able to share sets.");
            SelectFriend.Text = "";
            DeleteFriendBtn.Enabled = false;
        }
    }
}