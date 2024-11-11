using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class DeveloperAttribute : Attribute
    {
        public string Name { get; }
        public string LastModified { get; }

        public DeveloperAttribute(string name, string lastModified)
        {
            Name = name;
            LastModified = lastModified;
        }
    }
    [Developer("Abu", "2024-10-26")]
    public class Calculators
    {
        [Developer("Raju", "2024-10-29")]
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
