using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double farenheit = (9 * celsius / 5) + 32;

            Console.WriteLine("\n{0} degrees celsius = {1} degrees farenheit", celsius, farenheit);
            Console.Write("\nPress any key...");
            Console.ReadKey();
        }
    }
}
