using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Que8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallC = 25;
            int mediumC = 50;
            int largeC = 75;

            int coffeeChoice = 0;
            int coffeeTotal = 0;
            int moneyGiven = 0;
            int change = 0;

            bool validChoice = true;

            Console.WriteLine("Coffee Menu");
            Console.WriteLine("====");
            Console.WriteLine("1. Small Coffee: 25c\n2. Medium Coffee: 50c\n3. Large Coffee: 75c");
            Console.Write("Choose the coffee size which you prefer: ");
            coffeeChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Thread.Sleep(1000);
            switch (coffeeChoice)
            {
                case 1:
                    coffeeTotal = smallC;
                    break;
                case 2:
                    coffeeTotal = mediumC;
                    break;
                case 3:
                    coffeeTotal = largeC;
                    break;
                default:
                    Console.WriteLine("Incorrect coffee choice!");
                    validChoice = false;
                    break;
            }

            if (validChoice)// if (validChoice == true)
            {
                Console.WriteLine($"Kindly pay {coffeeTotal}c");
                moneyGiven = Convert.ToInt32(Console.ReadLine());

                if (moneyGiven < coffeeTotal)
                {
                    Console.WriteLine("Sorry but I cannot give you the coffee since you do not have enough money.");
                }
                else if (moneyGiven > coffeeTotal)
                {
                    change = moneyGiven - coffeeTotal;
                    Console.WriteLine($"Here is your coffee and {change}c as change");
                }
                else
                {
                    Console.WriteLine("Here is your coffee!");
                }
            }

            Console.ReadKey();
        }
    }
}
