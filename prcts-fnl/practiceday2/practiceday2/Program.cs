using practiceday2.Models;
using System;

namespace practiceday2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string password;
            string email;
            string fullName;
            string groupNo;
            int studentLimit;

            Console.WriteLine("Enter the Email");
            email = Console.ReadLine();

            Console.WriteLine("Enter fullname");
            fullName = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter the password");
                password = Console.ReadLine();

            } while (!PasswordChecker(password));

            User user = new User(email, fullName, password);

            Console.WriteLine("MENU");
            Console.WriteLine("1. Show Info");
            Console.WriteLine("2. Create new group");
            Console.WriteLine("3. Ashaghidaki menu");
            switch (Console.ReadLine())
            {
                case "1":
                    user.ShowInfo();
                    break;
                
                case "2":
                    do
                    {
                        Console.WriteLine("Enter the group No");
                        groupNo = Console.ReadLine();

                    } while (!Group.CheckGroupNo(groupNo));
                    

                    Console.WriteLine("Enter student limit");
                    studentLimit = Convert.ToInt32(Console.ReadLine());
                    
                    Group group = new Group(groupNo, studentLimit);
                    break;
                default:
                    break;
            }

        }
        public static bool PasswordChecker(string password)
        {
            bool hasDigit = false;
            bool hasUpper = false;
            bool hasLower = false;

            if (password.Length > 8)
            {
                foreach (var item in password)
                {
                    if (char.IsDigit(item))
                    {
                        hasDigit = true;
                        continue;
                    }
                    else if (char.IsUpper(item))
                    {
                        hasUpper = true;
                    }
                    if (char.IsLower(item))
                    {
                        hasLower = true;
                    }
                    if (hasDigit && hasLower && hasUpper)
                    return true;
                }

            }
            return false;
        }

    }
}
