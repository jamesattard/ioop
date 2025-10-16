using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Num: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
                Console.WriteLine($"{num} is positive.");
            else if (num < 0)
                Console.WriteLine($"{num} is negative.");
            else
                Console.WriteLine($"{num} is zero.");
            Console.ReadKey();
        }
    }
}
