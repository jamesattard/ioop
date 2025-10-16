
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskC
{
    internal class Program
    {
        static string PasswordValidatorMessage()
        {
            int digits = 0;
            string message = "";
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            if (password.Length < 10)
            {
                message += "A password must have at least ten characters.\n";
            }

            foreach (char c in password)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    message += "A password consists of only letters and digits.\n";
                    break;
                }
            }

            foreach (char c in password)
            {
                if (Char.IsDigit(c))
                {
                    digits++;
                }
            }

            if (digits < 2)
            {
                message += "A password must contain at least two digits.";
            }

            return message;
        }
        static bool PasswordValidator()
        {
            int digits = 0;
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            if (password.Length < 10)
            {
                return false;
            }

            foreach (char c in password)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    return false;
                }

                if (Char.IsDigit(c))
                {
                    digits++;
                }
            }

            if (digits < 2)
            {
                return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            //bool isValid = PasswordValidator();

            //if (isValid) // if(isValid == true)
            //{
            //    Console.WriteLine("Your password is valid!");
            //}
            //else
            //{
            //    Console.WriteLine("Your password is invalid!");
            //}

            string message = PasswordValidatorMessage();

            if (message == "")
            {
                Console.WriteLine("Your password is valid!");
            }
            else
            {
                Console.WriteLine(message);
            }

            Console.ReadKey();

        }
    }
}
