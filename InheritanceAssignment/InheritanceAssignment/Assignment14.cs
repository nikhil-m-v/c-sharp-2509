using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Persoon
    {
        public string Name { get; set; }

        public Persoon(string name)
        {
            Name = name;
        }
    }

    class Students : Persoon
    {
        // Hiding the Name property from the base class
        public new string Name { get; set; }
        public Students(string baseName, string studentName) : base(baseName)
        {
            Name = studentName;
        }

        public void DisplayNames()
        {
            Console.WriteLine($"Base class Name: {base.Name}");
            Console.WriteLine($"Derived class Name: {Name}");
        }
    }
}
