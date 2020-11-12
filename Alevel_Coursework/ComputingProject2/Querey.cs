using System;
using System.Text;
using System.Data.SQLite;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ComputingProject2
{
    class Querey
    {
        public string path, where;
        public SQLiteConnection connection;
        public SQLiteCommand command;
        public SQLiteDataReader reader;

        public Querey()
        {
            string location = "";

            DirectoryInfo directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            foreach (var fileInfo in directory.GetFiles())
            {
                if (fileInfo.FullName.IndexOf(".db") != -1)
                {
                    location = fileInfo.FullName;
                }
            }


            path = @"Data Source= " + location + "; Version = 3;";
        }

        public void AddParameter(string name, string data) // to prevent having to use same libraries serveral times
        {
            command.Parameters.Add(new SQLiteParameter(name, data));
        }

        public void AddParameter(string name, int data)
        {
            command.Parameters.Add(new SQLiteParameter(name, data));
        }

        public void AddParameter(string name, double data)
        {
            command.Parameters.Add(new SQLiteParameter(name, data));
        }

        public void Close()
        {
            if (reader != null)
            {
                if (!reader.IsClosed)
                    reader.Close();
            }
            reader = null;
            try
            {
                command.Reset();
                command.Dispose();
            }
            catch{ }
            try
            {
                connection.Close();
            }
            catch { }
        }

        public SQLiteConnection NewConn
        {
            get
            {
                var conn = new SQLiteConnection(path);
                conn.Open();
                return conn;
            }
        }

        public SQLiteCommand NewComm
        {
            get
            {
                return new SQLiteCommand(connection);
            }
        }        
    }
}
