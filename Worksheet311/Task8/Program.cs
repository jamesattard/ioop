using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers? ");
            int count = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter a number: ");
                double num = Convert.ToDouble(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine();
            double average = sum / Convert.ToDouble(count);
            Console.WriteLine("Average: {0:0.00}", average);
            Console.ReadKey();
        }
    }
}
