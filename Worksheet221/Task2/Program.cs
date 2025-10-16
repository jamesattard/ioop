using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two words separated by space: ");
            string words = Console.ReadLine();

            string word1 = words.Substring(0, words.IndexOf(' '));
            string word2 = words.Substring(words.IndexOf(' ')+1);

            Console.Write("In alphabetical order: ");
            if (word1.CompareTo(word2) == -1) 
                Console.WriteLine($"{word1} {word2}");
            else
                Console.WriteLine($"{word2} {word1}");
            Console.ReadKey();
        }
    }
}
