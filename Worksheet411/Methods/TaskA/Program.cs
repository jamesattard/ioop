using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskA
{
    internal class Program
    {
        static void CurrentDateTime()
        {
            Console.WriteLine(DateTime.Now);   
            
        }

        static void OddNumbersTo20()
        {
            Console.WriteLine("Odd numbers from 1 to 20:\n");
            for (int i = 1; i <= 20; i++)
            { 
                if(i % 2 != 0)
                    Console.WriteLine(i);
            }

        }
        static void Main(string[] args)
        {
            CurrentDateTime();
            Console.WriteLine();
            OddNumbersTo20();
            Console.ReadKey();
        }
    }
}
