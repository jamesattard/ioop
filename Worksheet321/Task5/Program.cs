using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            int[] randomNumbers = new int[5];
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = r.Next(1, 43);
            }
            Console.Write("The five random numbers are ");
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                Console.Write(randomNumbers[i]);
                if (i < randomNumbers.Length-1)
                    Console.Write(", ");
            }
            Console.ReadKey();

            // Using Generic List
            List<int> randomNumbers2 = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                randomNumbers2.Add(r.Next(1, 43)); // range 1..42
            }
            randomNumbers2.ForEach(num => Console.WriteLine(num));
        }
    }
}
