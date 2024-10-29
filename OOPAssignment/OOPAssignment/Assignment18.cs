using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Productss
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public Productss(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public Productss()
        {
            Name = "Default Product";
            Price = 0.0;
            Category = "General";
        }

        public static Productss CreateProduct(string name, double price, string category)
        {
            return new Productss(name, price, category);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Category: {Category}";
        }
    }
}

