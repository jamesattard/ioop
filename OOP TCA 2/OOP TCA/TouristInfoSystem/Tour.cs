using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristInfoSystem
{
    internal class Tour
    {
        string name;
        string description;
        float cost;

        List<Excursion> excursions = new List<Excursion>();

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public float Cost { get => cost; set => cost = value; }
        internal List<Excursion> Excursions { get => excursions; set => excursions = value; }
        


        public Tour(string name, string description, List<Excursion> excursions, float companyCost, float flightCost)
        {
            this.name = name;
            this.description = description;
            this.excursions = excursions;
            CalculateCost(companyCost, flightCost);
        }

       
        void CalculateCost(float companyCost, float flightCost)
        {
            Cost += companyCost + flightCost;

            foreach (Excursion excursion in excursions)
            {
                Cost += excursion.Cost;
            }
        }
    }
}
