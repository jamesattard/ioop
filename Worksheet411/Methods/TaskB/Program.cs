using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskB
{
    internal class Program
    {
        
        static void FutureInvestment(float investAmount, int interest, int years)
        {
            Console.WriteLine("Years \t Future Value");

            for(int i = 1; i <= years; i++)
            {
                investAmount += (interest / 100.0f) * investAmount;

                Console.WriteLine($"{i} \t {investAmount}");
            }
        }
     
        static void Matrix(int n)
        {
            Random rand = new Random();
            Console.WriteLine($"Matrix {n} x {n}");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int bit = rand.Next(2); // random number between 0 and 1
                    Console.Write($"{bit} ");
                }
                Console.WriteLine();
            }
            
        }
        static void CharsInBetween(char char1, char char2)
        {
            Console.WriteLine($"Characters between {char1} and {char2}:\n");

            if (char1 < char2)
            {
                for (int i = char1 + 1; i < char2; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = (int)char1 - 1; i > char2; i--)
                {
                    Console.Write((char)i + " ");
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Task B Question 1:\n");
            CharsInBetween('A', 'P');

            Console.WriteLine("\n");
            Console.Write("Character 1: ");
            char character1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Character 2: ");
            char char2 = Convert.ToChar(Console.ReadLine());

            CharsInBetween(character1, char2);

            Console.WriteLine("\nTask B Question 2:\n");

            Console.Write("How many rows and coloumns do you need? ");
            int n = Convert.ToInt32(Console.ReadLine());
            Matrix(n);

            Console.WriteLine("\nTask B Question 3:\n");
            Console.Write("Investment Amount: ");
            float investmentAmount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Interest: ");
            int interest = Convert.ToInt32(Console.ReadLine());
            Console.Write("Years: ");
            int years = Convert.ToInt32(Console.ReadLine());

            FutureInvestment(investmentAmount, interest, years);



            Console.ReadKey();
        }
    }
}
