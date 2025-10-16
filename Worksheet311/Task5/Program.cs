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
            Console.Write("Enter number from 1 to 12: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 12)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
                }
            }
            else
                Console.Write("Invalid Input");
            Console.ReadKey();
        }
    }
}
