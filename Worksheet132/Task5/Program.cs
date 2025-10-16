using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Perimeter
            Console.Write("Width of Square: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double perimeter = width * 4;
            
            Console.Write($"The perimeter of a square of width {width} is {perimeter}");
            Console.ReadKey();
        }
    }
}
