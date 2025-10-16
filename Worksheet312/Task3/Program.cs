using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            //while (input.ToUpper() != "Y" && input.ToUpper() != "N")
            while (!(input.ToUpper() == "Y" || input.ToUpper() == "N"))
            {
                Console.Write("Do you want ice-cream (Y\\N): ");
                input = Console.ReadLine();
                if (input.ToUpper() != "Y" && input.ToUpper() != "N")
                {
                    Console.WriteLine("Invalid input. Please try again");
                }
                else
                {
                    Console.WriteLine("Correct input");
                }
            }
            Console.ReadKey();
        }
    }
}
