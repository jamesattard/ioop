using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temperature in celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double farenheit = (9.0 * celsius / 5.0) + 32.0;

            Console.Write($"{celsius} celsius is equivalent to {farenheit} farenheit");
            Console.ReadKey();
        }
    }
}
