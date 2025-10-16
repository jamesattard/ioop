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
            Console.Write("Num 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Num 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int answer = num1 - num2;
            Console.WriteLine("\n{0} - {1} = {2}", num1, num2,answer);
            Console.Write("\nPress any key...");
            Console.ReadKey();
        }
    }
}
