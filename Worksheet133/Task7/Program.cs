using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount in Eur: ");
            double eur = Convert.ToDouble(Console.ReadLine());
            
            double lm = eur * 0.4293;
            Console.WriteLine("\nEur{0} is equivalent to Lm{1}", eur, lm);
            Console.Write("\nPress any key...");
            Console.ReadKey();
        }
    }
}
