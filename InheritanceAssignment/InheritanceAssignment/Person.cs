using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() 
        {
            Name = "Ravi";
            Age = 26;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name:{Name},Age:{Age}");
        }

    }
    public class Student : Person 
    {
        public int Grade {  get; set; }

        public Student()
        {
            Name = "Ravi";
            Age = 26;
            Grade = 86;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Name:{Name},Age:{Age},Grade:{Grade}");
        }
    }
}
