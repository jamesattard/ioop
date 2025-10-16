using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            // More or less
            Console.Write("Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int more = num - 1;
            int less = num + 1;
            
            Console.Write($"The number {num} is more than {more} but less than {less}.");
            Console.ReadKey();
        }
    }
}
