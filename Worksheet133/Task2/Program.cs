using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mark 1: ");
            double mark1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mark 2: ");
            double mark2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mark 3: ");
            double mark3 = Convert.ToDouble(Console.ReadLine());
            double average = (mark1 + mark2 + mark3) / 3.0;
            Console.WriteLine("\nAverage of {0}, {1}, and {2} is {3:N2}", mark1, mark2, mark3, average);

            Console.Write("\nPress any key...");
            Console.ReadKey();
        }
    }
}
