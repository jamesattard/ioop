using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10
{
    public class Food : Product
    {
        private DateTime expiryDate;        

        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }

        // Constructor
        public Food(string _name, double _price, int _stockQuantity, DateTime _expiryDate)
            : base(_name, _price, _stockQuantity)
        {
            expiryDate = _expiryDate;
        }


        // Overriding DisplayInfo to include unique attributes
        public override string GetInfo()
        {
            return base.GetInfo() + "\n" + "Expiry Date: " + expiryDate.ToShortDateString();                
        }

        public bool CheckExpiry()
        {
            if (expiryDate < DateTime.Now)
                return true;
            else
                return false;
        }
    }
}
