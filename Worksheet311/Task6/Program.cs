using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string strVowels = "aeiouAEIOU";
            int vowels = 0;
            int consonants = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                char c = sentence[i];
                if (char.IsLetter(c))
                {
                    if (strVowels.Contains(c))
                        vowels++;
                    else
                        consonants++;
                }
            }
            Console.WriteLine("Vowels: {0}", vowels);
            Console.WriteLine("Consonants: {0}", consonants);
            Console.ReadKey();
        }
    }
}
