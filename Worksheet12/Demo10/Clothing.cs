using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10
{
    public class Clothing : Product
    {
        private string size;
        private string colour;

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        // Constructor
        public Clothing(string _name, double _price, int _stockQuantity, string _size, string _colour)
            : base(_name, _price, _stockQuantity)
        {
            size = _size;
            colour = _colour;
        }


        // Overriding DisplayInfo to include unique attributes
        public override string GetInfo()
        {
            return base.GetInfo() + "\n" + "Size: " + size + "\n"
                + "Colour:"+ colour;
        }
    }
}
