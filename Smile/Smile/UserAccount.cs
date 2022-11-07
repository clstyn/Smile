using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile
{
    public class UserAccount: User
    {
        private string username;
        private string password;

        public string Username { set => username = value; }
        public string Password { set => password = value; }

        public UserAccount(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        public UserAccount() { }
    }
}
