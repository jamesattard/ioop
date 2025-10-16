using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Area Triangle
            Console.Write("Base: ");
            double triBase = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double triHeight = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * triBase * triHeight;
            area = Math.Round(area, 2);

            Console.Write($"The area of a triangle of base {triBase} & height {triHeight} is {area}");
            Console.ReadKey();
        }
    }
}
