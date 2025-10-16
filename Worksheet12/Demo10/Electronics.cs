using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10
{
    public class Electronics : Product
    {
        private int warrantyPeriod;
        private int powerUsage;

        public int WarrantyPeriod
        {
            get { return warrantyPeriod; }
            set { warrantyPeriod = value; }
        }

        public int PowerUsage
        {
            get { return powerUsage; }
            set { powerUsage = value; }
        }

        // Constructor
        public Electronics(string _name, double _price, int _stockQuantity, int _warrantyPeriod, int _powerUsage)
            : base(_name, _price, _stockQuantity)
        {
            warrantyPeriod = _warrantyPeriod;
            powerUsage = _powerUsage;
        }


        // Overriding DisplayInfo to include unique attributes
        public override string GetInfo()
        {
            Console.WriteLine("using this");
            return base.GetInfo() + "\n" + "Warranty Period: " + warrantyPeriod +
                  "\n" + "Power Usage:" + powerUsage;
        }
    }
}
