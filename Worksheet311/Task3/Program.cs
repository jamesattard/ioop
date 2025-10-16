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
            Console.WriteLine("Even nos");
            // Method 1 (recommended)
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}
            // Method 2
            //for (int i = 2; i <= 50; i += 2)
            //    Console.WriteLine(i);
            // Method 3
            for (int i = 1; i < 50; i++)
            {
                if (i % 2 != 0) // odd number
                    continue; // ignore any remaining code in this loop and go to increment
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
