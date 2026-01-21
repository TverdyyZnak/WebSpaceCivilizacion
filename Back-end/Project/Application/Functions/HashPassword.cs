using BCrypt.Net;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions
{
    public class HashPassword
    {
        private static string sKey = Environment.GetEnvironmentVariable(Constants._sKey);
        public static string CreateHashPass(string pass)
        {
            string hPass = BCrypt.Net.BCrypt.HashPassword(pass + sKey);
            return hPass;
        }

        public static bool VerifyPassword(string pass, string hash) 
        {
            return BCrypt.Net.BCrypt.Verify(pass + sKey, hash);
        }
    }
}
