using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = ""; //to intialise a string we can use "" or String.Empty

            Console.Write("Would you like an ice cream? ");
            answer = Console.ReadLine(); //answer = Console.ReadLine().ToLower();
            answer = answer.ToLower();//ToLower() is a method called on a string which
            //returns the same string in lower case

            switch(answer) 
            {
                case "yes":
                case "y":
                    Console.WriteLine("Here is your ice cream, enjoy!");
                    break;
                case "no": 
                case "n":
                    Console.WriteLine("Ok, bye!");
                    break;
                default:
                    Console.WriteLine("Incorrect input!");
                    break;
            }
            Console.ReadKey();

        }
    }
}
