using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
                Console.WriteLine("You are allowed in the club.");
            Console.ReadKey();
        }
    }
}
