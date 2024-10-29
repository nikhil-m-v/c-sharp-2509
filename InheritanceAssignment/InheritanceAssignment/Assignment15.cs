using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Vehiclee
    {
        public string Brand { get; set; }
        public Vehiclee(string brand)
        {
            Brand = brand;
            Console.WriteLine($"Vehicle created: {Brand}");
        }
    }
    class Carr : Vehiclee
    {
        public string Model { get; set; }

        // Constructor that passes value to the base class constructor
        public Carr(string brand, string model) : base(brand)
        {
            Model = model;
            Console.WriteLine($"Car Brand: {Brand}, Model: {Model}");
        }
    }
}
