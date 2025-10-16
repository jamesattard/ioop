using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Que6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int total = dice1 + dice2;

            Console.WriteLine("Press on Enter to roll the dice...");
            Console.ReadLine();
            Thread.Sleep(1000);
            Console.WriteLine($"{dice1} and {dice2} are rolled.");
            /*
                        if (total == 7 || total == 11)
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (total == 2)
                        {
                            Console.WriteLine("Snake Eyes!!");
                        }
                        else
                        {
                            Console.WriteLine("Try Again!");
                        }
            */
            switch (total)
            {
                case 7:
                case 11:
                    Console.WriteLine("You win!");
                    break;
                case 2:
                    Console.WriteLine("Snake Eyes!!");
                    break;
                default:
                    Console.WriteLine("Try Again!");
                    break; 
            }

            Console.ReadKey();
        }
    }
}
