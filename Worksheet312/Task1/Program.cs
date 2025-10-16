using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input words followed by return. Input * to quit");
            string input = string.Empty;
            int i = 0;
            while (input != "*")
            {
                input = Console.ReadLine();
                if (input != "*")
                    i++;
                // i = (input != "*") ? i + 1 : i; // example of a ternary expression (achieves the same thing as 19\20)
            }
            Console.WriteLine("You entered {0} words",i);
            Console.ReadKey();
        }
    }
}
