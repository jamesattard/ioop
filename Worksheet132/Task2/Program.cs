using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collect input
            Console.Write("First subject mark: ");
            double subject1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second subject mark: ");
            double subject2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Third subject mark: ");
            double subject3 = Convert.ToDouble(Console.ReadLine());

            // Processing
            double average = (subject1 + subject2 + subject3) / 3.0;
            average = Math.Round(average, 2); // round average mark to 2 decimal places

            // Print output
            Console.WriteLine($"The average of {subject1}, {subject2}, and {subject3} is {average}");
            Console.ReadKey();
        }
    }
}
