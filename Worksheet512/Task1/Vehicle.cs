using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
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
    }
}
