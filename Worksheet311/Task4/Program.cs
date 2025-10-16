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
            Console.Write("Min: ");
            int min = int.Parse(Console.ReadLine());
            
            Console.Write("Max: ");
            int max = int.Parse(Console.ReadLine());

            string inBetween = string.Empty;
            int sum = 0;
            for (int i = min+1; i < max; i++)
            {
                inBetween += i + ", ";
                sum += i; // sum = sum + i;
            }
            // Remove extra ", ";
            inBetween = inBetween.Substring(0, inBetween.Length - 2);
            Console.WriteLine("Numbers between {0} and {1} are: {2}", min, max, inBetween);
            Console.WriteLine("Sum of numbers in between is: {0}", sum);
            Console.ReadKey();
        }
    }
}
