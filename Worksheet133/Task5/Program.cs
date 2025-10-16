using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side of square: ");
            double side = Convert.ToDouble(Console.ReadLine());

            double perimeter = side * 4;

            Console.WriteLine("\nPerimeter of square with side {0} is {1}", side, perimeter);
            Console.Write("\nPress any key...");
            Console.ReadKey();
        }
    }
}
