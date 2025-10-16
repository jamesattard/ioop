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
            string[] names = new string[4];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Name {0}: ", i);
                names[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.Write("Enter name to search: ");
            string toSearch = Console.ReadLine();
            bool found = false;
            int position = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (toSearch == names[i])
                {
                    found = true;
                    position = i;
                    break;
                }
            }
            if (found) // if (found == true)
                Console.WriteLine("{0} found at position {1}", toSearch, position);
            else
                Console.WriteLine("{0} not found", toSearch);
            Console.ReadKey();

            // Using Generic List
            List<string> names2 = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter name: ");
                names2.Add(Console.ReadLine());
            }
            Console.Write("Name to search for: ");
            string toSearch2 = Console.ReadLine();

            bool found2 = names2.Any(name => name == toSearch2);
            if (found2)
                Console.WriteLine("{0} found at position {1}", toSearch2,
                    names2.IndexOf(toSearch2));
            else
                Console.WriteLine("{0} not found");
        }
    }
}
