using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristInfoSystem
{
    internal class VehicleExcursion : Excursion
    {
        int vehicleCapacity;
        string meetingPlace;

        public VehicleExcursion(string name, float cost, int vehicleCapacity, string meetingPlace)
        :base(name, cost)
        {
            this.vehicleCapacity = vehicleCapacity;
            this.meetingPlace = meetingPlace;
        }

        public void FindBestRoute()
        { }

        public override string ExcursionDetails()
        {
            return base.ExcursionDetails() + $", Vehicle Capacity: {vehicleCapacity}, Meeting Place: {meetingPlace}";
        }
    }
}
