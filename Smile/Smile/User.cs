using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile
{
    public class User
    {
        //attribute here
        public string usrName;
        public string usrGender;
        public DateTime usrBirthday;
        public int usrAge;

        //method here
        public void displayProfile()
        {

        }

        //constructor here
        public User(string usrName, string usrGender, DateTime usrBirthday, int usrAge)
        {
            this.usrName = usrName;
            this.usrGender = usrGender;
            this.usrBirthday = usrBirthday;
            this.usrAge = usrAge;
        }
        public User()
        {

        }
    }
}
