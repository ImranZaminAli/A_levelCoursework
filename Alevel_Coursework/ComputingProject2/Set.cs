using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingProject2
{
    public class Set
    {
        private int _id;
        private int _ownerId;
        private string _setName;
        private string _title1;
        private string _title2;
        private Flashcard[] _flashcards;
        private int _permissions;
        public int _maxCards;
        private double[] _strengths;
        private double _urgency;
        private Querey _querey = new Querey();
        private DateTime _last;
        private double _strength;

        public Set(int id, int ownerId, string setName, string title1, string title2)
        {
            _id = id;
            _ownerId = ownerId;
            _setName = setName;
            _title1 = title1;
            _title2 = title2;
            _querey = new Querey();
            _strengths = new double[] { 2.10, 3.48, 13.63, 59.16, 104.30, 153.92, 209.57, 313.04, 417.10, 521.39, 625.55 };

            using (_querey.connection = _querey.NewConn)
            {
                using (_querey.command = _querey.NewComm)
                {
                    _querey.command.CommandText = "SELECT count(SetId) FROM Flashcards WHERE SetId = @setid;";
                    _querey.AddParameter("@setid", _id);
                    int length = Convert.ToInt32(_querey.command.ExecuteScalar());
                    _flashcards = new Flashcard[length];
                }

                using (_querey.command = _querey.NewComm)
                {
                    _querey.command.CommandText = "SELECT Flashcards.Id, Flashcards.Text1, Flashcards.Text2 FROM Flashcards, Sets WHERE Flashcards.SetId = Sets.Id AND Flashcards.SetId = @id;";
                    _querey.AddParameter("@id", id);
                    using (_querey.reader = _querey.command.ExecuteReader())
                    {
                        int i = 0;
                        while (_querey.reader.Read())
                        {
                            _flashcards[i] = new Flashcard(_querey.reader.GetInt32(0), id, _querey.reader.GetString(1), _querey.reader.GetString(2));
                            i++;
                        }
                    }
                }
            }
        }

        public void CalculateUrgency(int userId)
        {
            using (_querey.connection = _querey.NewConn)
            {
                using (_querey.command = _querey.NewComm)
                {
                    _querey.command.CommandText = "SELECT LastReview, Strength FROM SetProgress WHERE UserId = @user AND SetId = @set;";
                    _querey.AddParameter("@user", userId);
                    _querey.AddParameter("@set", _id);

                    using (_querey.reader = _querey.command.ExecuteReader())
                    {
                        _querey.reader.Read();
                        _last = DateTime.Parse(_querey.reader.GetString(0));
                        _strength = _querey.reader.GetDouble(1);
                    }
                }
            }

            _urgency = Math.Pow(Math.E, -1 * (DateTime.Now - _last).TotalDays / _strength);

        }

        private int GetIndex(int userId) // gets the location of the current strength value from the strengths array
        {

            using (_querey.connection = _querey.NewConn)
            {
                using (_querey.command = _querey.NewComm)
                {
                    _querey.command.CommandText = "SELECT Strength FROM SetProgress WHERE UserId = @user AND SetId = @set;";
                    _querey.AddParameter("@user", userId);
                    _querey.AddParameter("@set", _id);

                    using (_querey.reader = _querey.command.ExecuteReader())
                    {
                        _querey.reader.Read();
                        _strength = _querey.reader.GetDouble(0);
                    }
                }
            }

            for (int i = 0; i < _strengths.Length; i++)
            {
                if (_strength == _strengths[i])
                {
                    return i;
                }

            }
            return -1; // will not be executed. Method requires something to be returned.
        }

        public void UpdateNextReview(int userId)
        {
            CalculateUrgency(userId);
            int index = GetIndex(userId);

            if (_urgency > 0.85)
            {
                new MessageForm("Too soon to be revised. Strength will stay the same.").Show();
            }
            else if (_urgency < 0.15)
            {
                new MessageForm("Revision has been left far too long. Strength value is going back to the initial one.").Show();
                _strength = _strengths[0];
            }
            else if(_urgency < 0.3)
            {
                string msg = "Revison has been left too long. ";
                if (_strength != _strengths[0])
                {
                    new MessageForm(msg + "Going back one strength value").Show();
                    int currentIndex = GetIndex(userId);
                    _strength = _strengths[currentIndex - 1];
                }
                else
                {
                    new MessageForm(msg + "Strength value is staying as the initial one").Show();
                }
            }
            else
            {
                string msg = "Revison successfully completed.";
                if (_strength == _strengths[_strengths.Length - 1])
                {
                    new MessageForm(msg).Show();
                }
                else
                {
                    new MessageForm(msg + " Strength is now incremented.").Show();
                    _strength = _strengths[GetIndex(userId) + 1];
                }
            }

            using (_querey.connection = _querey.NewConn)
            {
                using (_querey.command = _querey.NewComm)
                {
                    _querey.command.CommandText = "UPDATE SetProgress SET LastReview = @last, Strength = @strength WHERE UserId = @user AND SetId = @set;";
                    _querey.AddParameter("@last", DateTime.Now.ToString());
                    _querey.AddParameter("@strength", _strength);
                    _querey.AddParameter("@user", userId);
                    _querey.AddParameter("@set", _id);
                    _querey.command.ExecuteNonQuery();
                }
            }
            new GDrive().UploadDatabase();
        }

        public string SetName
        {
            get
            {
                return _setName;
            }
        }

        public Flashcard[] Flashcards
        {
            get
            {
                return _flashcards;
            }

            set
            {
                _flashcards = value;
            }
        }

        public void NewFlashcards(int n)
        {
            _flashcards = new Flashcard[n];
        }

        public string Title1
        {
            get
            {
                return _title1;
            }

            set
            {
                _title1 = value;
            }
        }

        public string Title2
        {
            get
            {
                return _title2;
            }

            set
            {
                _title2 = value;
            }
        }

        public double Urgency
        {
            get
            {
                return _urgency;
            }
        }
    }

    public class Flashcard
    {
        public int id;
        public int setId;
        public string text1;
        public string text2;

        public Flashcard(int id, int setId, string text1, string text2)
        {
            this.id = id;
            this.setId = setId;
            this.text1 = text1;
            this.text2 = text2;
        }

        
    }
}