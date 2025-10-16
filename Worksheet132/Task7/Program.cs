using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Euro to LM
            Console.Write("Euro: ");
            double euro = Convert.ToDouble(Console.ReadLine());

            double lm = euro * 0.4293;
            lm = Math.Round(lm, 2);

            Console.Write($"Eur{euro} is equivalent to LM{lm}.");
            Console.ReadKey();
        }
    }
}
