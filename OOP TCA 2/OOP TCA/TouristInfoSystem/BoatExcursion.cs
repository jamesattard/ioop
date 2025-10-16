using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristInfoSystem
{
    internal class BoatExcursion : VehicleExcursion
    {
        bool swimmingIncluded;

        public BoatExcursion(string name, float cost, int vehicleCapacity, string meetingPlace, bool swimmingIncluded)
        : base(name, cost, vehicleCapacity, meetingPlace)
        {
            this.swimmingIncluded = swimmingIncluded;
        }
        public override string ExcursionDetails()
        {
            string swim = "";
            if (swimmingIncluded)
                swim = "yes";
            else
                swim = "no";
            return base.ExcursionDetails() + $", Possiblilty to swim during the tour: {swim}";
        }
    }
}
