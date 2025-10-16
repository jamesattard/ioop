using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter height of triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter breadth of triangle: ");
            double breadth = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * height * breadth;

            Console.WriteLine("\nArea of triangle with height {0} and breadth {1} is {2}", height, breadth, area);
            Console.Write("\nPress any key...");
            Console.ReadKey();
        }
    }
}
