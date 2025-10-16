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
            //Write a program which prompts the user to enter the number of
            //students in a programming class. The program should then allow
            //the user to enter the names of the students in that class and store
            //them in an array. Finally, display the names of all the students in
            //uppercase.
            Console.Write("How many students in class? ");
            int numStudents = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[numStudents];

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter name {0}: ", i + 1);
                names[i] = Console.ReadLine();
            }
            foreach (string name in names)
            {
                Console.WriteLine(name.ToUpper());
            }
            Console.ReadKey();

            // Using generic list
            List<string> names2 = new List<string>();
            Console.Write("How many names? ");
            int noOfNames = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < noOfNames; i++)
            {
                names2.Add(Console.ReadLine());
            }
            for (int i = 0; i < noOfNames; i++)
            {
                names2[i] = names2[i].ToUpper();
            }
            names2.ForEach(name => Console.WriteLine(name));
        }
    }
}
