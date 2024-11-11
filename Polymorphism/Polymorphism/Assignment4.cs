using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee
    {
        static int totalEmployees;

        public Employee() 
        {
            totalEmployees++;
        }

        public static void DisplayEmployees()
        {
            Console.WriteLine($"Total Employees: {totalEmployees}");
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("I am an Employee");
        }
    }

    public class Manager : Employee 
    {
        public override void ShowDetails()
        {
            Console.WriteLine("I am a Manager");
        }
    }

    public class Developer : Employee 
    {
        public override void ShowDetails()
        {
            Console.WriteLine("I am a Developer");
        }
    }
}
