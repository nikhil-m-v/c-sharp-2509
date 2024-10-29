using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Employee
    {
        private double salary;
        
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative");
                }
                salary = value;
            }
        }
        public Employee()
        {
            Salary = salary;
        }
    }
}
