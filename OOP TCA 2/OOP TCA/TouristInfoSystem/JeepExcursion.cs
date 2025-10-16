    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristInfoSystem
{
    internal class JeepExcursion : VehicleExcursion
    {
        string terrainType;

        public JeepExcursion(string name, float cost, int vehicleCapacity, string meetingPlace, string terrainType)
        :base(name, cost, vehicleCapacity, meetingPlace)
        {
            this.terrainType = terrainType;
        }
        public override string ExcursionDetails()
        {
            return base.ExcursionDetails() + $", Terrain Type: {terrainType}";
        }
    }
}
