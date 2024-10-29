using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Personn
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Personn(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    class Employeee : Personn
    {
        public int EmployeeID { get; set; }

        public Employeee(string name, int age, int employeeID) : base(name, age)
        {
            EmployeeID = employeeID;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Employee ID: {EmployeeID}");
        }
    }
}
