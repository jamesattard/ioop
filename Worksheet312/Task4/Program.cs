using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1 Phone Book");
                Console.WriteLine("2 Messages");
                Console.WriteLine("3 Games");
                Console.WriteLine("4 Quit");
                Console.Write("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Phonebook");
                        Console.WriteLine("Press any key to go back to menu");
                        break;
                    case 2:
                        Console.WriteLine("Messages");
                        Console.WriteLine("Press any key to go back to menu");
                        break;

                    case 3:
                        Console.WriteLine("Games");
                        Console.WriteLine("Press any key to go back to menu");
                        break;
                    case 4:
                        Console.WriteLine("Press any key to quit");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                Console.ReadKey();
            } while (choice != 4);

        }
    }
}
