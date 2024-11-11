using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_5
{
    public class LoggingExample
    {
        public static void Divide(int a, int b)
        {
            try
            {
                int result = a / b;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Logger.LogError("Attempted to divide by zero.", ex);
                Console.WriteLine("DivideByZeroException caught and logged.");
            }
        }

    }
}
