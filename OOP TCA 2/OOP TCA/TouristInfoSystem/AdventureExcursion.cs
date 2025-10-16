using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristInfoSystem
{
    internal class AdventureExcursion : Excursion
    {
        bool fitnessRequirements;

        public AdventureExcursion(string name,  float cost, bool fitnessRequirements)
        :base(name, cost)
        {
            this.fitnessRequirements = fitnessRequirements;
        }
        public override string ExcursionDetails()
        {
            string req = "";
            if (fitnessRequirements)
                req = "yes";
            else
                req = "no";
            return base.ExcursionDetails() + $", Fitness Requirements: {req}";
        }
    }
}
