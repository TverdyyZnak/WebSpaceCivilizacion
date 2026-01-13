using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
    public class User
    {
        public Guid id { get; }
        public string login { get; } = string.Empty;
        public string hPassword { get; } = string.Empty;
        public string email { get; } = string.Empty;
        public bool isAdmin { get; } = false;

        private User(string login, string hPass, string email, bool isAdmin = false)
        {
            id = Guid.NewGuid();
            this.login = login;
            this.email = email;
            this.hPassword = hPass;
            this.isAdmin = isAdmin;
        }

        public (User? user, string error) CreateNewUser(string login, string password, string email, bool isAdmin = false)
        {
            string errorMsg = string.Empty;

            if(login.Length > Constants._nameLength)
            {
                errorMsg += "Text in field is too long; ";
            }

            if(password.Length > Constants._passLength)
            {
                errorMsg += "Text in Password field is too long; ";
            }
            
            if(errorMsg == string.Empty)
            {
                return (null, errorMsg);
            }
            else
            {
                return (new User(login, password, email, isAdmin), errorMsg);
            }
        }

    }
}
