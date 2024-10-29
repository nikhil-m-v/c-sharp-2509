using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Persons
    {
        public string Name { get; set; }
        public Persons(string name)
        {
            Name = name;
            Console.WriteLine($"Person constructor called for {Name}");
        }
    }
    class Employees : Persons
    {
        public int EmployeeID { get; set; }
        public Employees(string name, int employeeID) : base(name)
        {
            EmployeeID = employeeID;
            Console.WriteLine($"Employee constructor called for {Name} with ID: {EmployeeID}");
        }
    }
}
