using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10
{
    public class Product
    {
        private string name;
        private double price;
        private int stockQuantity;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { if (price >= 0) price = value; }
        }

        public int StockQuantity
        {
            get { return stockQuantity; }
            set { if (value >= 0) stockQuantity = value; }
        }

        // Constructor
        public Product(string _name, double _price, int _stockQuantity)
        {
            name = _name;

            if (_price >= 0) price = _price;
            else price = 0;

            if (_stockQuantity >= 0)
                stockQuantity = _stockQuantity;
            else
                stockQuantity = 0;
        }

        // Method to display product information
        public virtual string GetInfo()
        {
            return "Name: " + name + "\n" +
                   "Price: Eur" + price + "\n" +
                   "StockQuantity: " + stockQuantity;
        }

        public double ApplyDiscount(int discount)
        {
            return price - (price * discount / 100.0);
        }
    }
}
