using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userCoin = 0;

            Console.Write("Enter a coin (for 1Eur and 2Eur use 100 and 200): ");
            userCoin = Convert.ToInt32(Console.ReadLine()); 

            switch (userCoin) 
            {
                case 1:
                case 2:
                case 5:
                case 10:
                case 20:
                case 50:
                    Console.WriteLine($"Coin {userCoin}cents is valid!");
                    break;
                case 100:
                case 200:
                    Console.WriteLine($"Coin Eur{userCoin/100} is valid!");
                    break;
                default:
                    Console.WriteLine("Invalid coin!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
