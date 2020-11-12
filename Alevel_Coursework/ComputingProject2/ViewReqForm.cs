using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace ComputingProject2
{
    public partial class ViewReqForm : Form
    {
        private Student _student;
        private Teacher _teacher;
        private int _userId;
        Dictionary<int, string> requestSenders;
        Querey querey = new Querey();
        int senderId;


        public ViewReqForm()
        {
            InitializeComponent();
            requestSenders = new Dictionary<int, string>();

        }

        public ViewReqForm(Student student) : this()
        {
            ChangeBtnStatus(false);
            _student = student;
            _userId = _student.Id;
            using (querey.connection = querey.NewConn)
            {
                using (querey.command = querey.NewComm)
                {
                    querey.command.CommandText = "SELECT FriendRequest.SenderId, Users.Firstname, Users.Secondname FROM Users, FriendRequest WHERE FriendRequest.SenderId = Users.Id AND FriendRequest.ReceiverId = @receiver;";

                    Initialise();
                }
            }
        }

        public ViewReqForm(Teacher teacher) : this()
        {
            _teacher = teacher;
            _userId = _teacher.Id;

            using (querey.connection = querey.NewConn)
            {
                using (querey.command = querey.NewComm)
                {
                    querey.command.CommandText = "SELECT StudentId, Users.Firstname, Users.Secondname FROM Users, TeacherRequest WHERE StudentId = Users.Id AND TeacherId = @receiver;";

                    Initialise();
                }
            }
        }

        private void Initialise() // used a procedure so i wouldnt have to write the smae code out twice
        {
            SetParameters();

            using (querey.reader = querey.command.ExecuteReader())
            {
                while (querey.reader.Read()) // sets up drop down menu
                {
                    requestSenders.Add(querey.reader.GetInt32(0), querey.reader.GetString(1) + " " + querey.reader.GetString(2));
                    ViewRequests.Items.Add(requestSenders[querey.reader.GetInt32(0)]);
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (_student != null)
            {
                new ConnForm(_student).Show();
            }
            else
            {
                new MngeStudentsForm(_teacher).Show();
            }
            this.Close();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            if(ViewRequests.Text == "")
            {
                new MessageForm("Please select a request.").Show();
            }
            else if(!requestSenders.ContainsValue(ViewRequests.Text))
            {
                new MessageForm(ViewRequests.Text + " has not sent you a request.").Show();
            }
            else
            {
                foreach(var pair in requestSenders)
                {
                    if(pair.Value == ViewRequests.Text)
                    {
                        senderId = pair.Key;
                    }
                }

                SenderDetailsTxt.Text = senderId.ToString() + " : " + requestSenders[senderId];
                ChangeBtnStatus(true);
            }
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            using (querey.connection = querey.NewConn)
            {
                DeleteRequest();

                using (querey.command = querey.NewComm)
                {
                    querey.command.CommandText = "INSERT INTO "  + (_student == null ? "TeacherStudent (StudentId, TeacherId) " : "Friends (Student1, Student2) ") + "VALUES (@sender, @receiver);";
                    SetParameters();
                    querey.command.ExecuteNonQuery();
                }

                if (_teacher == null)
                {
                    InsertFriends(senderId, _userId);
                }
                InsertFriends(_userId, senderId);
            }

            ViewRequests.Text = "";
            ChangeBtnStatus(false);
            new MessageForm("Request accepted.").Show();
            SenderDetailsTxt.Text = "";
            new GDrive().UploadDatabase();
            SendEmail("Request Accepted", "Hello " + requestSenders[senderId] + ",\n\n" + (_student == null ? _teacher.FirstName + " " + _teacher.LastName : _student.FirstName) + "has accepted your friend request.");
        }

        private void InsertFriends(int owner,  int user)
        {
            List<int> setIds = new List<int> { };
            using (querey.command = querey.NewComm)
            {
                querey.command.CommandText = "SELECT Id FROM Sets WHERE OwnerId = @owner";
                querey.AddParameter("@owner", owner);
                SetParameters();
                using (querey.reader = querey.command.ExecuteReader())
                {
                    while (querey.reader.Read())
                    {
                        setIds.Add(querey.reader.GetInt32(0));
                    }
                }
            }

            foreach (int setId in setIds)
            {
                using (querey.command = querey.NewComm)
                {
                    querey.command.CommandText = "INSERT INTO Permissions (SetId, UserId) VALUES(@setId, @user);";
                    querey.AddParameter("@user", user);
                    querey.AddParameter("@setId", setId);
                    querey.command.ExecuteNonQuery();
                }

                using (querey.command = querey.NewComm)
                {
                    double initialStrength = 2.1;
                    querey.command.CommandText = "INSERT INTO SetProgress (UserId, SetId, LastReview, Strength) VALUES(@user, @setId, @now, @strength);";
                    querey.AddParameter("@user", user);
                    querey.AddParameter("setId", setId);
                    querey.AddParameter("@now", DateTime.Now.ToString());
                    querey.AddParameter("@strength", initialStrength);
                    querey.command.ExecuteNonQuery();
                }
            }
        }

        private void RejectBtn_Click(object sender, EventArgs e)
        {
            using (querey.connection = querey.NewConn)
            {
                DeleteRequest();
            }

            new MessageForm("Request rejected.").Show();
            SendEmail("Friend Request Declined", "Hello " + requestSenders[senderId] + ",\n\n" + (_student == null ? _teacher.FirstName + " " + _teacher.LastName : _student.FirstName) + "has rejected your friend request.");
            ViewRequests.Text = "";
            ChangeBtnStatus(false);
            SenderDetailsTxt.Text = "";
            new GDrive().UploadDatabase();
        }

        private void DeleteRequest()
        {
            using (querey.command = querey.NewComm)
            {
                if (_student == null)
                {
                    querey.command.CommandText = "DELETE FROM TeacherRequest WHERE StudentId = @sender AND TeacherId = @receiver;";
                }
                else
                {
                    querey.command.CommandText = "DELETE FROM FriendRequest WHERE SenderId = @sender AND ReceiverId = @receiver OR ReceiverId = @sender AND SenderId = @receiver;";
                }
                SetParameters();
                querey.command.ExecuteNonQuery();
            }
        }

        private void SetParameters()
        {
            querey.AddParameter("@sender", senderId);
            querey.AddParameter("@receiver", _userId);
        }

        private void SendEmail(string subject, string message)
        {
            string senderEmail;
            using (querey.connection = querey.NewConn)
            {
                using (querey.command = querey.NewComm)
                {
                    querey.command.CommandText = "SELECT Email FROM Users WHERE Id = @sender";
                    querey.AddParameter("@sender", senderId);
                    using (querey.reader = querey.command.ExecuteReader())
                    {
                        querey.reader.Read();
                        senderEmail = querey.reader.GetString(0);
                    }
                }

                new Email(senderEmail, subject, message);
            }
        }

        private void ChangeBtnStatus(bool change)
        {
            AcceptBtn.Enabled = change;
            RejectBtn.Enabled = change;
        }
    }
}