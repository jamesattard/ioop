using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10
{
    public class Furniture : Product
    {
        private string material;
        private int weight;

        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        // Constructor
        public Furniture(string _name, double _price, int _stockQuantity, string _material, int _weight)
            : base(_name, _price, _stockQuantity)
        {
            material = _material;
            weight = _weight;
        }


        // Overriding DisplayInfo to include unique attributes
        public override string GetInfo()
        {            
            return base.GetInfo() + "\n" + "Material: " + material +
                  "\n" + "Weight: " + weight;
        }

        public bool EligibleForDelivery()
        {
            if (weight > 40)
                return true;
            return false;
        }
    }
}
