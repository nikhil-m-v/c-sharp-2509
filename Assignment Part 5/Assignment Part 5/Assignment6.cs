using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_5
{
    public class MathOps
    {
        // Method to divide two integers and return the quotient and remainder using out parameters
        public void Divide(int numerator, int denominator, out int quotient, out int remainder)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }

            quotient = numerator / denominator;
            remainder = numerator % denominator;
        }
    }

}
