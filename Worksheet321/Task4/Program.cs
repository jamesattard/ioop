using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Write a program which prompts the user to enter a set of numbers
            //in an array. The program then computes and displays the total
            //sum and average of the numbers input.

            Console.Write("How many numbers? ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[arraySize];
            // Set numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number {0}: ", i+1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Compute total
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i]; // total = total + numbers[i];
            }
            // total = numbers.Sum();

            // Compute average
            double average = Convert.ToDouble(total) / Convert.ToDouble(numbers.Length);
            // average = numbers.Average();

            Console.WriteLine("Total is {0}", total);
            Console.WriteLine("Average is {0:0.00}", average);
            Console.ReadKey();

            // Using Generic List
            Console.Write("How many numbers? ");
            int noOfNumbers = Convert.ToInt32(Console.ReadLine());
            List<int> numbers2 = new List<int>();
            for (int i = 0; i < noOfNumbers; i++)
            {
                Console.Write("Enter number {0}", i + 1);
                numbers2.Add(Convert.ToInt32(Console.ReadLine()));
            }
            double sum2 = numbers2.Sum();
            double avg2 = numbers2.Average();
        }
    }
}
