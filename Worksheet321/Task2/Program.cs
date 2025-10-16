using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Write a program to perform the following operations:
            //(a) Declare an array numbers and initialize the array with the data
            //listed above.
            //(b) Display the number of elements in the array
            //(c) Display the contents of the array

            int[] numbers = new int[] { 20, 5, 15, 10, 25, 35, 30 };
            Console.WriteLine("Number of elements in the array: {0}", numbers.Length);
            Console.Write("Array Content: ");
            for (int i = 0; i < numbers.Length; i++)
			{
                Console.Write(numbers[i]);
                if (i < numbers.Length - 1)
                    Console.Write(", ");
			}
            Console.ReadKey();

            // Using Generic Lists
            List<int> numbers2 = new List<int>() { 20, 5, 15, 10, 25, 35, 30 };
            Console.WriteLine("List contains {0} numbers", numbers2.Count);
            numbers2.ForEach(num => Console.WriteLine(num));
        }
    }
}
