using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Num: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 1 && num <= 100)
                Console.WriteLine($"{num} is within range 1 - 100.");
            else
                Console.WriteLine($"{num} is outside range 1 - 100.");

            Console.ReadKey();
        }
    }
}
