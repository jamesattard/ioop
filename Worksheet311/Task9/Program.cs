using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int sum = 0;
            // Method 1
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Enter number: ");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if (num == -1)
            //        break;
            //    else
            //        sum += num;
            //}
            // Method 2
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Enter number: ");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if (num == -1)
            //        i = 10;
            //    else
            //        sum += num;
            //}
            // Method 3
            for (int i = 0; (i < 10 && num != -1); i++)
            {
                Console.Write("Enter number: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num != -1)
                    sum += num;
            }
            Console.WriteLine("Sum: {0}", sum);
            Console.ReadKey();
        }
    }
}
