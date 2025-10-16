using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle avensis = new Vehicle("MCT-001", "Toyota", "Avensis", 1500, 7.9, 50);
            Console.WriteLine(avensis.GetData());
            Console.WriteLine("Fill up tank...");
            avensis.FillUpFuelTank();
            Console.WriteLine(avensis.GetData());
            Console.WriteLine("Trip to Bugibba...");
            bool tripCompleted = avensis.MakeTrip("Bugibba");
            if (tripCompleted)
                Console.WriteLine("Trip Completed!");
            else
                Console.WriteLine("Trip Aborted due to insufficient fuel");
            Console.WriteLine(avensis.GetData());
            Console.ReadKey();
        }
    }
}
