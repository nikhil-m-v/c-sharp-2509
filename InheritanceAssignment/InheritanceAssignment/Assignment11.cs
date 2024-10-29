using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Animals
    {
        public string Name { get; set; }

        public Animals(string name)
        {
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }
    class Dogs : Animals
    {
        public Dogs(string name) : base(name) { }

        public void Bark()
        {
            Console.WriteLine($"{Name} is barking!");
        }
    }
}
