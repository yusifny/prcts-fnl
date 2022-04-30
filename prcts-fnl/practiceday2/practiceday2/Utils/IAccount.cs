using System;
using System.Collections.Generic;
using System.Text;

namespace practiceday2.Utils
{
    interface IAccount
    {
        public bool PasswordChecker(string Password);
        public void ShowInfo();
    }
}
