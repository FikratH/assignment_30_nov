using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace assignment_30_nov
{
    public class User
    {
        private string _username;
        private string _password;
        bool isCorrectUsername = false;
        bool isCorrectPassword = false;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                    isCorrectUsername = true;
                }
                else
                {
                    //sen indi burda ne etmek isteyirsen? username ve password ikiside duzgundurse isSuperAdmin = true;
                    Console.WriteLine("Username must be over 6 characters");
                }
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (Regex.IsMatch(value, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{6,}$"))
                {
                    _password = value;
                    isCorrectPassword = true;
                }
                else
                {
                    Console.WriteLine("Password must be over 6 characters, must contain at least 1 digit and at least 1 uppercase number");
                }
            }
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
