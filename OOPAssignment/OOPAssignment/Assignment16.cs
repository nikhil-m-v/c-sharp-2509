using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    class Cars
    {
        public string make;
        public string model;
        public int year;
        public int price;

        public Cars(string make) : this(make, "Unknown", 0, 0)
        {
        }

        public Cars(string make, string model) : this(make, model, 0, 0)
        {
        }

        public Cars(string make, string model, int year) : this(make, model, year, 0)
        {
        }
        public Cars(string make, string model, int year, int price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Make: {make}, Model: {model}, Year: {year}, Price: {price}");
        }
    }
}
