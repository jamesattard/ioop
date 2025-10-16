using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskD
{
    internal class Program
    {
        static string MiddleCharacters(string text)
        {
            int pos = text.Length / 2;
            if (text.Length % 2 != 0)
            {               
                return text[pos].ToString();
            }
            else
            {
                return text[pos - 1].ToString() + " " + text[pos].ToString();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a string to find its middle characters: ");
            string middleChars = MiddleCharacters(Console.ReadLine());

            Console.WriteLine($"The middle character/s for your string is/are {middleChars}");
            Console.ReadKey();
        }
    }
}
