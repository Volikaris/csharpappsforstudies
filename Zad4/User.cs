using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    public class User
    {
        List<User> users = new List<User>();
        public string fName, lName, eMail;
        public User(string fName, string lName, string eMail)
        {
            this.fName = fName;
            this.lName = lName;
            this.eMail = eMail;
        }
        private string getUsers()
        {
            string usersToString = "";
            for(int i = 0; i < users.Count; i++)
            {
                usersToString += users[i].ToString();
            }
            return usersToString;
        }
        public string getUser()
        {
            string userData = "";
            userData += fName + " " + lName + " : " + eMail;
            return userData;
        }
        public void setUserData(string fName, string lName, string eMail)
        {
            this.fName = fName;
            this.lName = lName;
            this.eMail = eMail;
        }
    }
}
