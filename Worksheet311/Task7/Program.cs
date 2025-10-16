using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                intList.Add(num);
            }
            intList.Sort();
            Console.WriteLine("Sum: {0}", intList.Sum());
            Console.WriteLine("Min: {0}", intList[0]);
            Console.WriteLine("Max: {0}", intList[intList.Count-1]);
            Console.ReadKey();

            //    // Initialization
            //    int sum = 0;
            //int min = int.MaxValue;
            //int max = int.MinValue;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Enter a number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    sum += num;
            //    if (num < min)
            //        min = num;
            //    if (num > max)
            //        max = num;
            //}
            //Console.WriteLine();
            //Console.WriteLine("Sum: {0}", sum);
            //Console.WriteLine("Min: {0}", min);
            //Console.WriteLine("Max: {0}", max);
            //Console.ReadKey();
        }
    }
}
