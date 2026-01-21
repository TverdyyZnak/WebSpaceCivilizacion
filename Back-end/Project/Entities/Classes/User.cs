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
        public string hPassword { get; set;  } = string.Empty;
        public string email { get; } = string.Empty;
        public bool isAdmin { get; } = false;

        private User(Guid id, string login, string hPass, string email, bool isAdmin)
        {
            this.id = id;
            this.login = login;
            this.email = email;
            this.hPassword = hPass;
            this.isAdmin = isAdmin;
        }


        public static (User user, string error) CreateNewUser(Guid id, string login, string password, string email, bool isAdmin)
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
               
            return (new User(id, login, password, email, isAdmin), errorMsg);
        }
    }
}
