using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    //abstract class
    public abstract class Vehicle
    {
        public abstract void StartEngine();
        public void StopEngine()
        {
            Console.WriteLine("Engine Stopped");
        }
    }
    public class Car : Vehicle
    {
        public override void StartEngine() //abstract method overriding
        {
            Console.WriteLine("Car Engine Started");
        }
    }

    public class Motorcycle : Vehicle 
    {
        public override void StartEngine() 
        {
            Console.WriteLine("Motorcycle Engine Started");
        }
    }
}
