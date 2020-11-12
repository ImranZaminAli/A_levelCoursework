using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ComputingProject2
{
    class Encrypt
    {
        string hashed;

        public Encrypt(string plainText)
        {
            hashed = "";
            using (SHA256 sHA256 = SHA256.Create())
            {
                byte[] compute = sHA256.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                foreach (byte b in compute)
                {
                    hashed += b.ToString("x2");
                }
            }
        }

        public string Hashed
        {
            get
            {
                return hashed;
            }
        }
    }
}
