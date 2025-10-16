using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = 0;
            int year = 0;
            //dataType[] arrayName = {all items}; --> data type for each item in the array
            string[] months = {"January", "February", "March", "April", "May", "June", "July",
            "August", "September", "October", "November", "December"};
            //C# is 0 index based so the first item is at position 0

            Console.Write("Enter a month as a number: ");
            month = Convert.ToInt32(Console.ReadLine());

            switch (month) 
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"{months[month - 1]} has 31 days.");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"{months[month - 1]} has 30 days.");
                    break;
                case 2:
                    Console.Write("Enter the year: ");
                    year = Convert.ToInt32(Console.ReadLine());

                    if (((year % 4 == 0) && (year % 100 != 0)) || ((year % 400 == 0) && (year % 100 == 0)))
                    {
                        Console.WriteLine($"{months[1]} for the year {year} has 29 days");
                    }
                    else
                    {
                        Console.WriteLine($"{months[1]} for the year {year} has 28 days");
                    }
                    break;
                default:
                    Console.WriteLine("Incorrect month!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
