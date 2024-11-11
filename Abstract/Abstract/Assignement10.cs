using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Calculator
    {
        public static int Divide(int numerator, int denominator)
        {
            try
            {
                return numerator / denominator;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0; // Return a default value, or handle it as needed
            }
        }
    }

}
