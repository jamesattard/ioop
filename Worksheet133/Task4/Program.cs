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
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine("\nArea of circle with radius {0} is {1}", radius, area);
            Console.Write("\nPress any key...");
            Console.ReadKey();
        }
    }
}
