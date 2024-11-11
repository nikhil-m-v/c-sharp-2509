using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public partial class Employee
    {
        public string Name { get; set; }
        public int HoursWorked { get; set; }
        public int HourlyRate { get; set; }

        // Declaration of the partial method
        partial void CalculateSalary();
    }

    public partial class Employee
    {
        // Implementation of the partial method
        partial void CalculateSalary()
        {
            int salary = HoursWorked * HourlyRate;
            Console.WriteLine($"Salary for {Name}: {salary}");
        }
        public void DisplaySalary()
        {
            CalculateSalary();
        }
    }
}
