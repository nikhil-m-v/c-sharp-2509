using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    abstract class Vehicles
    {
        public abstract void Drive();
    }

    class Car : Vehicles
    {
        public override void Drive()
        {
            Console.WriteLine("Driving Car");
        }
    }
    class Bike : Vehicles
    {
        public override void Drive()
        {
            Console.WriteLine("Driving Bike");
        }
    }

}
