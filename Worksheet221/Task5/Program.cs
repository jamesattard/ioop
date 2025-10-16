using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Num: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int mod = num % 2; // does it leave a remainder when divided by 2?
            if (mod == 0)
                Console.WriteLine($"{num} is an even number.");
            else
                Console.WriteLine($"{num} is an odd number.");
            
            Console.ReadKey();
        }
    }
}
