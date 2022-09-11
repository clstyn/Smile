using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile
{
    public class UserAccount: User
    {
        private string usrUname;
        private string usrPassword;

        public void credentialCheck()
        {

        }
        public UserAccount(string usrUname, string usrPassword)
        {
            this.usrUname = usrUname;
            this.usrPassword = usrPassword;
        }
        public string usrEmail_
        {
            set { this.usrUname = value; }
        }
        public string usrPassword_
        {
            set { this.usrPassword = value; }
        }
    }
}
