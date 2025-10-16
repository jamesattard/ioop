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
            for (int i = 0; i < 255; i++)
            {
                char c = (char)i; // casting from integer to char
                Console.WriteLine(c);
                if (i != 0 && i % 20 == 0) // multiplier of 20
                {
                    Console.WriteLine("Press any key to display next 20...");
                    Console.ReadKey();
                    Console.Clear(); // erase text from screen
                }
            }
            Console.ReadKey();
        }
    }
}
