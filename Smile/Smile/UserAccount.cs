using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile
{
    public class UserAccount: User
    {
        private string id;
        private string username;
        private string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Id { get => id; set => id = value; }

        public static UserAccount logedUser;
    }
}
