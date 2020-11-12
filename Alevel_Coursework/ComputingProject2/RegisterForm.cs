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
using System.Text.RegularExpressions;

namespace ComputingProject2
{
    public partial class RegisterForm : Form
    {
        string key;
        GDrive drive = new GDrive();
        public RegisterForm()
        {
            InitializeComponent();
            KeyBtn.Enabled = false;
            Resend.Enabled = false;
            Student.Checked = true;
            key = "";
        }

        private void Fail(string errorMsg)
        {
            MessageForm errorForm = new MessageForm(errorMsg);
            errorForm.Show();
        }

        private void SendKey()
        {
            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)) // host and port
            {
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("project.alevel@gmail.com", "abc123");
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;

                MailMessage mailMessage = new MailMessage("project.alevel@gmail.com", Email.Text, "Account Confiramation", "Hello " + FirstName.Text + "\nThank you for creating an account.\nHere is your confirmation key:\t" + key);

                smtpClient.Send(mailMessage);
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            string errormsg = "";
            string pattern = @"^([A-Za-z0-9]+[!#$%&'*+\-/=?^_`{|.(),:;[\]]?)+@[A-Za-z0-9-.]+([-.]\w+)*\.\w+([-.]\w+)*$"; // regex
            if (FirstName.Text == "")
            {
                errormsg += "Please enter your first name.\n\n";
            }
            if (LastName.Text == "")
            {
                errormsg += "Please enter your second name.\n\n";
            }
            if (Email.Text == "")
            {
                errormsg += "Please enter your email address.\n\n";
            }
            else if (!Regex.IsMatch(Email.Text, pattern))
            {
                errormsg += "Please enter a valid email address.\n\n";
            }
            if (Password.Text == "")
            {
                errormsg += "Please enter your password.\n\n";
            }
            if (RepPassword.Text == "")
            {
                errormsg += "Please re-enter your password.\n\n";
            }
            if (errormsg != "")
            {
                Fail(errormsg);
            }
            else
            {
                if (Password.Text != RepPassword.Text)
                {
                    Fail("The passwords do not match.");
                }
                else
                {
                    Querey checkEmail = new Querey();
                    using (checkEmail.connection = checkEmail.NewConn)
                    {
                        using (checkEmail.command = checkEmail.NewComm)
                        {
                            checkEmail.command.CommandText = "SELECT Email FROM Users WHERE Email LIKE @email;";
                            checkEmail.AddParameter("@email", Email.Text);
                            checkEmail.reader = checkEmail.command.ExecuteReader();

                            using (checkEmail.reader)
                            {
                                if (checkEmail.reader.Read())
                                {
                                    Fail("This email address is already linked to an account.");
                                }
                                else
                                {
                                    Random rnd = new Random();
                                    for (int i = 0; i < 20; i++)
                                    {
                                        key += (char)rnd.Next(33, 127);
                                    }

                                    SendKey();
                                    KeyBtn.Enabled = true;
                                    Resend.Enabled = true;
                                }
                            }
                        }
                    }
                }

            }


        }

        private void KeyBtn_Click(object sender, EventArgs e)
        {
            if (KeyIn.Text == key)
            {
                Querey insert = new Querey();
                using (insert.connection = insert.NewConn)
                {
                    using (insert.command = insert.NewComm)
                    {
                        Encrypt encrypt = new Encrypt(Password.Text);

                        insert.command.CommandText = "INSERT INTO Users (Firstname, Secondname, Email, Teacher, Password) VALUES (@first, @last, @email, @teacher, @pass);";
                        insert.AddParameter("@first", FirstName.Text);
                        insert.AddParameter("@last", LastName.Text);
                        insert.AddParameter("@email", Email.Text);
                        insert.AddParameter("@teacher", Teacher.Checked ? "1" : "0");
                        insert.AddParameter("@pass", encrypt.Hashed);

                        insert.command.ExecuteNonQuery();
                    }

                    if (Teacher.Checked)
                    {

                        int id;

                        using (insert.command = insert.NewComm)
                        {
                            insert.command.CommandText = "SELECT Id FROM Users ORDER BY Id DESC;";
                            using (insert.reader = insert.command.ExecuteReader())
                            {
                                insert.reader.Read();
                                id = insert.reader.GetInt32(0);
                            }
                        }
                        string key = id.ToString() + "x"; // creating teacher key for connecting to students
                        foreach (char character in FirstName.Text)
                        {
                            key += ((int)character).ToString();
                        }
                        using (insert.command = insert.NewComm)
                        {
                            insert.command.CommandText = "INSERT INTO Teacher (TeacherId, InviteKey) VALUES (@id, @key);";
                            insert.AddParameter("@id", id);
                            insert.AddParameter("@key", key);

                            insert.command.ExecuteNonQuery();
                        }

                        new MessageForm("inserted into teacher table").Show();
                    }
                }
                drive.UploadDatabase();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void Resend_Click(object sender, EventArgs e)
        {
            SendKey();
        }
    }
}
