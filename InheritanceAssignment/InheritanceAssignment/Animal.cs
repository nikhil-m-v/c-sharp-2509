using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking");
        }
    }
    public class Puppy : Dog
    {
        public void Weep() { Console.WriteLine("Weeping"); }
    }
}
