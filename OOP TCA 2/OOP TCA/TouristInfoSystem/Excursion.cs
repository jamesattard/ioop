using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristInfoSystem
{
    internal class Excursion
    {
        string name;
        float cost;

        public string Name { get => name; set => name = value; }
        public float Cost { get => cost; set => cost = value; }

        public Excursion(string name, float cost)
        {
            this.name = name;
            this.cost = cost;
        }
        public virtual string ExcursionDetails()
        {
            return $"Excursion Name: {name}, Cost: Eur{cost}";
        }
    }
}
