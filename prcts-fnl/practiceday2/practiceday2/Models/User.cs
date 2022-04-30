using practiceday2.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace practiceday2.Models
{
    class User : IAccount
    {
        private int _id;
        private string _password;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password
        {
            get => _password;
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
            }
        }

        public User(string email, string fullName, string password)
        {
            _id++;
            Id = _id;
            Email = email;
            Fullname = fullName;
            Password = password;
        }

        public bool PasswordChecker(string password)
        {
            bool hasdigit = false;
            bool hasupper = false;
            bool haslower = false;

            if (password.Length > 8)
            {
                foreach (var item in password)
                {
                    if (char.IsDigit(item))
                    {
                        hasdigit = true;
                        continue;
                    }
                    else if (char.IsUpper(item))
                    {
                        hasupper = true;
                    }
                    if (char.IsLower(item))
                    {
                        haslower = true;
                    }
                    if(hasdigit && haslower && hasupper)
                        return true;
                }

            }
            return false;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}\n Fullname: {Fullname}\n Id: {Email}\n");
        }
    }
}
