using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to perform the following operations:
            //(a) Declare an array country to store 5 country names
            //(b) Fill in the country names at design time.
            //Example: country[0] = "Malta";
            //(c) Use a for() loop to display the contents of the array
            //(d) Use a foreach() loop to display the contents of the array

            string[] countries = new string[5];
            //countries = new string[] { "Malta", "France" };

            countries[0] = "Malta";
            countries[1] = "France";
            countries[2] = "Italy";
            countries[3] = "Belgium";
            countries[4] = "Netherlands";

            Console.WriteLine("Using for loop...");
            for (int i = 0; i < countries.Length; i++)
            {
                string country = countries[i];
                Console.WriteLine(country);
            }
            Console.WriteLine();
            Console.WriteLine("Using foreach loop...");
            foreach (string country in countries)
            {
                Console.WriteLine(country);
            }
            Console.ReadKey();

            // Using Generic Lists
            List<string> countries2 = new List<string>();
            countries2.Add("Malta");
            countries2.Add("France");
            countries2.Add("Italy");
            countries2.Add("Belgium");
            countries2.Add("Netherlands");

            for (int i = 0; i < countries2.Count; i++)
            {
                string country2 = countries2[i];
                Console.WriteLine(country2);
            }

            foreach (string country2 in countries2)
            {
                Console.WriteLine(country2);
            }

            countries2.ForEach(country2 => Console.WriteLine(country2));
        }
    }
}
