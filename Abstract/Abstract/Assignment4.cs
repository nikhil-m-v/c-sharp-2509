using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    // Interface for swimm
    interface ISwim
    {
        void Swim();
    }

    // Abstract class for birds
    public abstract class Bird
    {
        public abstract void Fly();
    }

    // Class that inherits from Bird and implements ISwim
    public class Duck : Bird, ISwim
    {
        // Implementing Fly method
        public override void Fly()
        {
            Console.WriteLine("Duck is flying.");
        }

        // Implementing Swim method
        public void Swim()
        {
            Console.WriteLine("Duck is swimming.");
        }
    }

}
