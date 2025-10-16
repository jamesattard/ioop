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
            set { price = value; }
        }

        public int StockQuantity
        {
            get { return stockQuantity; }
            set { stockQuantity = value; }
        }

        // Constructor
        public Product(string _name, double _price, int _stockQuantity)
        {
            name = _name;
            price = _price;
            stockQuantity = _stockQuantity;
        }

        // Method to display product information
        public virtual string GetInfo()
        {
            return "Name: " + name + "\n" +
                   "Price: Eur" + price + "\n" +
                   "StockQuantity: " + stockQuantity;
        }
    }
}
