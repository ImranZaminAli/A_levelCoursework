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
    public partial class LoginForm : Form
    {
        int id;
        string email, firstName, lastName, password;
        bool teacher;
        int sets;
        List<int> ids;

        public LoginForm()
        {
            InitializeComponent();
            ids = new List<int>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool success = false;
            Querey getUserDetails = new Querey();

            using (getUserDetails.connection = getUserDetails.NewConn)
            {
                using (getUserDetails.command = getUserDetails.NewComm)
                {
                    getUserDetails.command.CommandText = "SELECT Id, Email, Firstname, Secondname, Password, Teacher FROM Users WHERE Email LIKE @email AND Password = @pass;";
                    Encrypt encrypt = new Encrypt(Password.Text);
                    getUserDetails.AddParameter("@email", Email.Text);
                    getUserDetails.AddParameter("@pass", encrypt.Hashed);

                    getUserDetails.reader = getUserDetails.command.ExecuteReader();
                    using (getUserDetails.reader)
                    {
                        if (getUserDetails.reader.Read()) // getting user details
                        {
                            id = getUserDetails.reader.GetInt32(0);
                            email = getUserDetails.reader.GetString(1);
                            firstName = getUserDetails.reader.GetString(2);
                            lastName = getUserDetails.reader.GetString(3);
                            password = getUserDetails.reader.GetString(4);
                            teacher = (getUserDetails.reader.GetString(5) == "1"); // if the value stored is 1 then teacher will be set to true

                            success = true;
                        }
                    }
                }
            }

            if (!success)
            {
                MessageForm errorForm = new MessageForm("Username or password is incorrect");
                errorForm.Show();
            }
            else
            {

                List<int> ids = new List<int> { };

                Querey getIds = new Querey();
                using (getIds.connection = getIds.NewConn)
                {
                    using (getIds.command = getIds.NewComm)
                    {
                        if (teacher)
                        {
                            getIds.command.CommandText = "SELECT StudentId FROM TeacherStudent, Users WHERE TeacherId = Users.Id AND TeacherId = @id";
                            getIds.AddParameter("@id", id);

                            getIds.reader = getIds.command.ExecuteReader();
                            using (getIds.reader)
                            {
                                while (getIds.reader.Read())
                                {
                                    ids.Add(getIds.reader.GetInt32(0));
                                    MessageForm errorForm = new MessageForm(getIds.reader.GetInt32(0).ToString());
                                    errorForm.Show();
                                }
                            }

                            Teacher teacherAcc = new Teacher(id, email, firstName, lastName, ids);
                            new TeacherMainMenu(teacherAcc).Show();
                            this.Close();
                        }
                        else
                        {

                            getIds.command.CommandText = "SELECT Student1 FROM Friends WHERE Student2 = @id;";
                            getIds.AddParameter("@id", id);

                            getIds.reader = getIds.command.ExecuteReader();
                            using (getIds.reader)
                            {
                                while (getIds.reader.Read())
                                {
                                    ids.Add(getIds.reader.GetInt32(0));
                                }
                            }

                            getIds.command.CommandText = "SELECT Student2 FROM Friends WHERE Student1 = @id;";
                            getIds.AddParameter("@id", id);
                            getIds.reader = getIds.command.ExecuteReader();

                            using (getIds.reader)
                            {
                                while (getIds.reader.Read())
                                {
                                    ids.Add(getIds.reader.GetInt32(0));
                                }
                            }

                            Student studentAcc = new Student(id, email, firstName, lastName, ids);
                            StudentMainMenu studentMainMenu = new StudentMainMenu(studentAcc);
                            studentMainMenu.Show();
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
