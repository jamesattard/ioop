using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 0;

            Console.Write("Enter a year to check if it is a leap year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || ((year % 400 == 0) && (year % 100 == 0)))
            {
                Console.WriteLine($"Year {year} is a leap year!");
            }
            else
            {
                Console.WriteLine($"Year {year} is not a leap year!");
            }

            Console.ReadKey();
        }
    }
}
