using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class Program
    {
        static int FindMax(int num1, int num2)
        {
            int max = 0;
            if (num1 > num2)
            {
                max = num1;
            }
            else
            {
                max = num2;
            }

            return max;
        }

        static int FindMax(int num1, int num2, int num3)
        {
            int max = 0;
            if((num1 > num2) && (num1 > num3)) 
            {
                max = num1;
            }
            else if((num2 > num1) && (num2 > num3))
            {
                max = num2;
            }
            else
            {
                max = num3;
            }
            return max;
        }

        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            int max1 = 0;
            int max2 = 0;

            Console.Write("Number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            max1 = FindMax(num1, num2);
            max2 = FindMax(num1, num2, num3);

            Console.WriteLine($"The maximum of the first two numbers is {max1} and the maximum" +
                $" for all the inserted numbers is {max2}");

            Console.ReadKey();
        }

    }
}
