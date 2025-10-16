using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Vehicle
    {
        string vin;
        string make;
        string model;
        int weight;
        double fuelConsumption;
        double fuelCapacity;
        double fuelLevel;

        public Vehicle()
        {
            vin=string.Empty;
            make = string.Empty;
            model = string.Empty;
            weight=0;
            fuelConsumption = 0;
            fuelCapacity = 0;
            fuelLevel = fuelCapacity / 2.0;
        }

        public Vehicle(string pVin, string pMake, string pModel, int pWeight, 
            double pFuelConsumption, double pFuelCapacity)
        {
            vin = pVin;
            make = pMake;
            model = pModel;
            weight = pWeight;
            fuelConsumption = pFuelConsumption;
            fuelCapacity = pFuelCapacity;
            fuelLevel = fuelCapacity / 2.0;
        }

        public string GetData()
        {
            return $"VIN: {vin}; Make: {make}; Model: {model}; Weight: {weight}kg; " +
                $"Consumption {fuelConsumption}l per 100km; Capacity: {fuelCapacity}l; Level: {fuelLevel}l";
        }

        public void FillUpFuelTank()
        {
            fuelLevel = fuelCapacity;
        }

        public bool MakeTrip(string destination)
        {
            bool result = false;
            double fuelNeeded = 0;
            switch (destination.ToUpper())
            {
                case "VALLETTA":
                    fuelNeeded = 8.0 / 100.0 * fuelConsumption; // fuelConsumption / 100.0 * 8.0
                    break;
                case "SLIEMA":
                    fuelNeeded = 10.0 / 100.0 * fuelConsumption;
                    break;
                case "BUGIBBA":
                    fuelNeeded = 19.0 / 100.0 * fuelConsumption;
                    break;
            }
            if (fuelLevel >= fuelNeeded) // we can do the trip
            {
                result = true;
                fuelLevel -= fuelNeeded;
            }
            return result;
        }
    }
}
