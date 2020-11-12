using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace ComputingProject2
{
    public partial class CreateSetForm : Form
    {
        private Microsoft.Office.Interop.Excel.Application _app;
        private Microsoft.Office.Interop.Excel.Workbook _workbook;
        private Microsoft.Office.Interop.Excel.Worksheet _worksheet;
        private Microsoft.Office.Interop.Excel.Range _range;
        private string _path;
        private string[,] _data;
        private int _num;
        private int _userId;
        private Student _student;
        private Teacher _teacher;

        public CreateSetForm()
        {
            InitializeComponent();
            _data = new string[64, 2];
            ConfirmMsg.Enabled = false;
        }

        public CreateSetForm(Student student) : this()
        {
            _student = student;
            _userId = student.Id;
        }

        public CreateSetForm(Teacher teacher) :this()
        {
            _teacher = teacher;
            _userId = teacher.Id;
        }

        private void Insert_Click(object sender, EventArgs e) // inserts set into database and then updates cloud
        {
            Querey getSetId = new Querey();
            bool used;
            using (getSetId.connection = getSetId.NewConn)
            {
                using (getSetId.command = getSetId.NewComm)
                {
                    SetIdCommand(getSetId);
                    using (getSetId.reader = getSetId.command.ExecuteReader())
                    {
                        used = getSetId.reader.Read();
                    }
                }
            }

            if (SetName.Text == "")
            {
                MessageForm errorForm = new MessageForm("Please enter a set name.");
                errorForm.Show();
            }
            else if (!used)
            {
                if (Title1.Text == "" || Title2.Text == "")
                {
                    MessageForm errorForm = new MessageForm("Please enter titles for your sets.");
                    errorForm.Show();
                }
                else
                {
                    Querey insert = new Querey();
                    using (insert.connection = insert.NewConn)
                    {
                        using (insert.command = insert.NewComm)
                        { 
                            insert.command.CommandText = "INSERT INTO Sets (OwnerId, SetName, Title1, Title2) VALUES (@owner, @name, @title1, @title2);";
                            insert.AddParameter("@owner", _userId);
                            insert.AddParameter("@name", SetName.Text);
                            insert.AddParameter("@title1", Title1.Text);
                            insert.AddParameter("@title2", Title2.Text);
                            if (insert.connection.State != ConnectionState.Open)
                            {
                                insert.connection.Open();
                            }
                            insert.command.ExecuteNonQuery();
                            insert.Close();
                        }
                    }

                    getSetId = new Querey();
                    int setId;
                    using (getSetId.connection = getSetId.NewConn)
                    {
                        using (getSetId.command = getSetId.NewComm)
                        {
                            SetIdCommand(getSetId);
                            using (getSetId.reader = getSetId.command.ExecuteReader())
                            {
                                getSetId.reader.Read();
                                setId = getSetId.reader.GetInt32(0);
                            }
                        }
                    }

                    insert = new Querey();
                    using (insert.connection = insert.NewConn)
                    {
                        int count = 0;
                        while (count < 64 && _data[count, 0] != null)
                        {
                        
                            using (insert.command = insert.NewComm)
                            {
                                insert.command.CommandText = "INSERT INTO Flashcards (SetId, Text1, Text2) VALUES (@setId, @text1, @text2);";
                                insert.AddParameter("@setId", setId);
                                insert.AddParameter("@text1", _data[count, 0]);
                                insert.AddParameter("@text2", _data[count, 1]);
                                insert.command.ExecuteNonQuery();
                                count++;
                            }

                            
                        }

                        string[] tables = { "Permissions", "SetProgress" }; // done this way to allow easier error checking and make queries more readable
                        for (int i = 0; i < tables.Length; i++)
                        {


                            using (insert.command = insert.NewComm)
                            {
                                if (_student != null)
                                {
                                    insert.command.CommandText = "INSERT INTO " + tables[i] + " (UserId, SetId) SELECT Users.Id, Sets.Id FROM Users, Sets, Friends WHERE Student1 = @id AND Sets.Id = @setId AND Sets.OwnerId = Student1 AND Users.Id = Student2 OR Student2 = @id AND Sets.Id = @setId AND Sets.OwnerId = Student2 AND Users.Id = Student1;";
                                }
                                else
                                {
                                    insert.command.CommandText = "INSERT INTO " + tables[i] + " (UserId, SetId) SELECT Users.Id, Sets.Id FROM Users, Sets, TeacherStudent WHERE TeacherId = @id AND Sets.Id = @setId AND Sets.OwnerId = TeacherId AND Users.Id = StudentId;";
                                }
                                insert.AddParameter("@id", _userId);
                                insert.AddParameter("@setId", setId);
                                insert.command.ExecuteNonQuery();
                                new MessageForm("inserted").Show();
                            }
                        }

                        using (insert.command = insert.NewComm)
                        {
                            insert.command.CommandText = "INSERT INTO SetProgress (UserId, SetId) SELECT OwnerId, Id FROM Sets WHERE id = @setId;";
                            insert.AddParameter("setId", setId);
                            insert.command.ExecuteNonQuery();
                        }

                        using (insert.command = insert.NewComm)
                        {
                            double initialStrength = 2.10;
                            insert.command.CommandText = "UPDATE SetProgress SET LastReview = @now, Strength = @strength WHERE SetId = @set;";
                            insert.AddParameter("@now", DateTime.Now.ToString());
                            insert.AddParameter("@strength", initialStrength);
                            insert.AddParameter("@set", setId);

                            insert.command.ExecuteNonQuery();
                        }
                    }

                    GDrive drive = new GDrive();
                    drive.UploadDatabase();

                    ConfirmMsg.Enabled = false;
                    OpenFile.Reset();
                    SetName.Clear();
                    Title1.Clear();
                    Title2.Clear();
                    OpenFile.Reset();
                    FileName.Text = "";
                }
            }
            else
            {
                MessageForm errorForm = new MessageForm("This set name has already been used. Please choose a different one.");
                errorForm.Show();
            }
        }

        private void SetIdCommand(Querey getSetId)
        {
            if (getSetId.connection.State == ConnectionState.Closed)
            {
                getSetId.connection.Open();
            }
            getSetId.command.CommandText = "SELECT Id FROM Sets WHERE SetName LIKE @name";
            getSetId.AddParameter("@name", SetName.Text);
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (_num < 64)
            {
                _data[_num, 0] = Text1.Text;
                _data[_num, 1] = Text2.Text;
                _num++;
            }
            else
            {
                MessageForm errorForm = new MessageForm("You can have a maximum of 64 cards");
            }

            Text1.Clear();
            Text2.Clear();

        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = OpenFile.ShowDialog(); // alows user to chose a file

            if(result == DialogResult.OK)
            {
                _path = OpenFile.FileName;
                if (OpenFile.FileName.IndexOf(".xlsx") == -1)
                {
                    MessageForm errorForm = new MessageForm("The selected file is not a .xlsx");
                }
                else
                {
                    Tuple<System.Drawing.Point, Size> initial = new Tuple<System.Drawing.Point, Size>(FileName.Location, FileName.Size); // for adjusting label on screen
                    FileName.Text = OpenFile.FileName;
                    FileName.Location = new System.Drawing.Point((FileName.Location.X - (FileName.Size.Width - initial.Item2.Width) / 2), initial.Item1.Y);

                    _app = new Microsoft.Office.Interop.Excel.Application();
                    _workbook = _app.Workbooks.Open(_path);
                    _worksheet = _workbook.Sheets[1];
                    _range = _worksheet.UsedRange;
                    int i = 0;

                    while (i<64 && _range.Value2[i+1,1] != null) // while the maximum number of flashcards has not been reached and data is still present
                    {
                        _data[i, 0] = (string) _range[i + 1, 1].Value2.ToString();
                        _data[i, 1] = (string) _range[i + 1, 2].Value2.ToString();
                        i++;
                    }

                    GC.Collect(); //closing everything correctly so that the file can be used again by the user
                    GC.WaitForPendingFinalizers();

                    Marshal.ReleaseComObject(_range);
                    Marshal.ReleaseComObject(_worksheet);

                    _workbook.Close();

                    Marshal.ReleaseComObject(_workbook);

                    _app.Quit();
                    Marshal.ReleaseComObject(_app);

                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (_student != null)
            {
                new StudentMainMenu(_student).Show();
            }
            else
            {
                new TeacherMainMenu(_teacher).Show();
            }
            this.Close();
        }
    }
}