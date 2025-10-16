using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collect input
            Console.Write("First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Processing
            int result = num1 - num2;

            // Print output
            Console.WriteLine($"{num1} - {num2} = {result}");
            Console.ReadKey();
        }
    }
}
