using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Vehicle
    {
        public virtual void Drive() 
        {
            Console.WriteLine("Vehicle is driving");
        }
    }

    public class Car : Vehicle 
    {
        public override void Drive() 
        {
            Console.WriteLine("Car is driving");
        }
    }
}
