using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Que7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuChoice = 0;

            Console.WriteLine("Menu");
            Console.WriteLine("====");
            Console.WriteLine("1. Messages\n2. Settings\n3. Games\n4. Exit");
            Console.Write("Choice: ");
            menuChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Thread.Sleep(1000);
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("Welcome to the Messages menu!");
                    break;
                case 2:
                    Console.WriteLine("Welcome to the Settings menu!");
                    break;
                case 3:
                    Console.WriteLine("Welcome to the Games menu!");
                    break;
                case 4:
                    Console.WriteLine("Thank you for using our app!");
                    break;
                default:
                    Console.WriteLine("Incorrect menu choice!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
