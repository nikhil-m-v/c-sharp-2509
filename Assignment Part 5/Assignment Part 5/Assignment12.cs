using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_5
{
    class NegativeNumberException : Exception
    {
        
        public NegativeNumberException(string message) : base(message)
        {
        }
    }

    class NumberValidator
    {
        public static void CheckNumber(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberException("The number is negative");
            }
        }
    }
}
