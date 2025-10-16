using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int more = num+1;
            int less = num-1;

            Console.WriteLine("\nThe number {0} is more than {1} but less than {2}", num, less, more);
            Console.Write("\nPress any key...");
            Console.ReadKey();
        }
    }
}
