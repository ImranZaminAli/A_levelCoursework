using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingProject2
{
    public class Base
    {
        private int _id;
        private string _email;
        private string _firstName;
        private string _lastName;
        private int _maxSets;
        private int _sets;


        public Base(int id, string email,string firstName, string lastName, List<int> ids)
        {
            _id = id;
            _email = email;
            _firstName = firstName;
            _lastName = lastName;
            _maxSets = 64;
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
        }


    }

    public class Student : Base
    {
        List<int> friends;
        public Tuple<int,string> teacherConn = null;

        public Student(int id, string email, string firstName, string lastName, List<int> ids) : base(id, email, firstName, lastName, ids)
        {
            friends = ids;
            

            Querey getTeacherLink = new Querey();
            using (getTeacherLink.connection = getTeacherLink.NewConn)
            {
                using (getTeacherLink.command = getTeacherLink.NewComm)
                {
                    getTeacherLink.command.CommandText = "SELECT TeacherId, FirstName, SecondName FROM Users, TeacherStudent WHERE StudentId = " + id + " AND StudentId = Users.Id;";
                    getTeacherLink.reader = getTeacherLink.command.ExecuteReader();
                    using (getTeacherLink.reader)
                    {
                        if (getTeacherLink.reader.Read())
                        {
                            teacherConn = new Tuple<int, string>(getTeacherLink.reader.GetInt32(0), getTeacherLink.reader.GetString(1) + " " + getTeacherLink.reader.GetString(2));
                        }
                    }
                }
            }
        }

    }

    public class Teacher : Base
    {
        List<int> _students;
        private string _lastName;

        string _key;

        public Teacher(int id, string email, string firstName, string lastName, List<int> ids) : base(id, email, firstName, lastName, ids)
        {
            _students = ids;
            Querey getKey = new Querey();
            using (getKey.connection = getKey.NewConn)
            {
                using (getKey.command = getKey.NewComm)
                {
                    getKey.command.CommandText = "SELECT InviteKey FROM Teacher WHERE TeacherId = @id";
                    getKey.AddParameter("@id", id);

                    using (getKey.reader = getKey.command.ExecuteReader())
                    {
                        getKey.reader.Read();
                        _key = getKey.reader.GetString(0);
                    }
                }
            }

            _lastName = lastName;
        }
        
        public string LastName
        {
            get
            {
                return _lastName;
            }
        }

        public string Key
        {
            get
            {
                return _key;
            }
        }
    }

}