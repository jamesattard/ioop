using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;
            // area = Math.PI * Math.Pow(radius, 2);

            area = Math.Round(area, 2);

            Console.Write($"The area of a circle with radius {radius} is {area}");
            Console.ReadKey();
        }
    }
}
