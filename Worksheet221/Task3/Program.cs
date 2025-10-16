using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess number between 1 and 10: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            int num = r.Next(1, 11); // generate number
            if (guess == num)
                Console.WriteLine("You guessed the number.");
            else
                Console.WriteLine($"Better luck next time. Random number was {num}.");
            Console.ReadKey();
        }

        static Random r = new Random();
    }
}
