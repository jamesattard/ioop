using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            int[] randomNumbers = new int[5];
            for (int i = 0; i < randomNumbers.Length; i++) // to generate 5 numbers
            {
                int randomNumber = 0;
                bool alreadyDrafted = false;
                do // to ensure no duplicates
                {
                    // Generate number
                    randomNumber = r.Next(1, 7);
                    alreadyDrafted = false;
                    // Check whether it has already been drafted
                    for (int j = 0; j < i; j++) // compare with previous numbers
                    {
                        if (randomNumber == randomNumbers[j])
                        {
                            alreadyDrafted = true;
                            break;
                        }
                    }
                } while (alreadyDrafted);
                randomNumbers[i] = randomNumber;
            }
            Console.Write("The five random numbers are ");
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                Console.Write(randomNumbers[i]);
                if (i < randomNumbers.Length - 1)
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
