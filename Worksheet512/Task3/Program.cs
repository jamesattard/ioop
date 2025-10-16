using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static Vehicle avensis = new Vehicle("MCT-001", "Toyota", "Avensis", 1500, 7.9, 50);
        static Vehicle accord = new Vehicle("MCT-002", "Honda", "Accord", 2000, 9.2, 60);
        static Vehicle passat = new Vehicle("MCT-003", "Volkswagen", "Passat", 1800, 8.5, 70);
        static List<Vehicle> fleet = new List<Vehicle>() { avensis, accord, passat};

        static string ShowMenu()
        {
            string result = string.Empty;
            Console.Clear();
            //foreach (Vehicle v in fleet)
            //{
            //    Console.WriteLine(v.GetData());
            //}
            fleet.ForEach(v => Console.WriteLine(v.GetData()));
            Console.WriteLine("\nMenu\n----");
            Console.WriteLine("1. Fill Up Tank");
            Console.WriteLine("2. Make Trip");
            Console.WriteLine("3. Quit");
            Console.Write("Choice: ");
            result = Console.ReadLine();
            return result;
        }

        static void Main(string[] args)
        {
            string choice = string.Empty;
            do
            {
                choice = ShowMenu();
                Console.WriteLine();
                switch (choice)
                {
                    case "1": // Fill up tank
                        HandleFillUpTank();
                        break;
                    case "2": // Make Trip
                        HandleMakeTrip();
                        break;
                }
                Console.Write("Press a key...");
                Console.ReadKey();
            } while (choice != "3");
            
            Console.ReadKey();
        }

        static void PrintSuccessMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Success: {message}");
            Console.ResetColor();
        }

        static void PrintErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {message}");
            Console.ResetColor();
        }

        static Vehicle GetVehicle()
        {
            Vehicle result = null;
            Console.Write("VIN: ");
            string varVin = Console.ReadLine();
            // Search the car with that specific varVin in the fleet
            //foreach (Vehicle v in fleet)
            //    if (v.vin == varVin)
            //        result = v;
            result = fleet.FirstOrDefault(v => v.vin == varVin);

            return result;
        }

        static void HandleFillUpTank()
        {
            Console.WriteLine("Fill Up Fuel Tank");
            Console.WriteLine("-----------------\n");
            Vehicle v = GetVehicle();
            if (v == null)
                PrintErrorMessage("Vehicle not found.");
            else
            {
                v.FillUpFuelTank();
                PrintSuccessMessage("Fuel tank filled up successfully.");
            }
        }

        static void HandleMakeTrip()
        {
            Console.WriteLine("Make Trip");
            Console.WriteLine("---------\n");
            Vehicle v = GetVehicle();
            if (v == null)
                PrintErrorMessage("Vehicle not found.");
            else
            {
                string destination = GetDestination();
                bool tripCompleted = v.MakeTrip(destination);
                if (tripCompleted)
                    PrintSuccessMessage($"Trip to {destination} completed.");
                else
                    PrintErrorMessage("Trip not completed due to insufficient fuel.");
            }
        }

        static string GetDestination()
        {
            string result = string.Empty;
            bool destinationValid = false;
            do
            {
                Console.Write("Destination (Sliema\\Valletta\\Bugibba): ");
                result = Console.ReadLine();
                destinationValid = (
                    result.ToUpper() == "SLIEMA" ||
                    result.ToUpper() == "VALLETTA" ||
                    result.ToUpper() == "BUGIBBA");
                if (!destinationValid)
                    PrintErrorMessage("Invalid destination input.");
            }
            while (!destinationValid); // destinationValid == false
            return result;
        }
    }
}
