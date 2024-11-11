using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Base class Appliance
    public abstract class Appliance
    {
        // Readonly property to hold the model of the appliance
        public string Model { get; }

        // Constructor to initialize the readonly property
        protected Appliance(string model)
        {
            Model = model;
        }

        // Abstract method to be implemented by derived classes
        public abstract void Operate();
    }

    // Derived class WashingMachine
    public class WashingMachine : Appliance
    {
        public WashingMachine(string model) : base(model) { }

        // Implementation of the Operate method
        public override void Operate()
        {
            Console.WriteLine($"{Model} Washing Machine is now washing clothes.");
        }
    }

    // Derived class Refrigerator
    public class Refrigerator : Appliance
    {
        public Refrigerator(string model) : base(model) { }

        // Implementation of the Operate method
        public override void Operate()
        {
            Console.WriteLine($"{Model} Refrigerator is now cooling.");
        }
    }
}
