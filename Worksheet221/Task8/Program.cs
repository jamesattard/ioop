using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            //convert to American dollars(Lm1 = $3)
            //convert to British pounds(Lm1 = £1.65)
            //convert to Canadian dollars(Lm1 = $2.3)

            Console.Write("Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("To Currency (american dollar, pound, canadian dollar): ");
            string toCurrency = Console.ReadLine();
            double convertedAmount = 0;

            if (toCurrency == "american dollar")
                convertedAmount = amount * 3.0;
            else if (toCurrency == "pound")
                convertedAmount = amount * 1.65;
            else if (toCurrency == "canadian dollar")
                convertedAmount = amount * 2.3;

            Console.WriteLine($"{amount} converted to {toCurrency} is {convertedAmount}.");
            Console.ReadKey();
        }
    }
}
