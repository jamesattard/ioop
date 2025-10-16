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
            int age = 0;

            while (age < 1 || age > 100)
            // while (!(age >= 1 && age <= 100))
                {
                Console.Write("Enter age (1-100): ");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 1 || age > 100)
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
                else
                {
                    Console.WriteLine("Correct input");
                }
            }
            Console.ReadKey();
        }
    }
}
