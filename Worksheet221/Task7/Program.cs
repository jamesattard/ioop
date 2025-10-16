using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Num: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Second Num: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Operator (+,-,*,/): ");
            string oper = Console.ReadLine();

            double result = 0;

            switch (oper)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    result = firstNum / secondNum;
                    break;
            }
            Console.WriteLine($"{firstNum}{oper}{secondNum}={result}");
            Console.ReadKey();

            
        }
    }
}
