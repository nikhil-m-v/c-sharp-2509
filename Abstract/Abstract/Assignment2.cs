using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Animal
    {
        public virtual void MakeSound()//virtual method 
        {
            Console.WriteLine("Animal is making sound");
        }
    }

    public class Dog : Animal 
    {
        public override void MakeSound() //overriding
        {
            Console.WriteLine("Dog is barking");
        }
    }
    public class Cat : Animal 
    {
        public override void MakeSound() 
        {
            Console.WriteLine("Cat is meowing");
        }
    }

}
