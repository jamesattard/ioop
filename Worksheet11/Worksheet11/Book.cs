using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet11
{  
    public class Book
    {
        // Private fields (encapsulation)
        private string isbn;
        private string title;
        private string author;
        private double price;
        private int quantity;

        // Constructor to initialize the attributes
        public Book(string isbn, string title, string author, double price, int quantity)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.price = price;
            this.quantity = quantity;
        }

        // Getter methods
        public string Isbn
        {
            get{ return isbn;}
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }       

        // Method to display book details
        public string GetData()
        {
            return $"ISBN: {isbn}, Title: {title}, Author: {author}, Price: ${price:F2}, Quantity: {quantity}";
        }
    }

}
