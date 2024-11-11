using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public static class IntExtensions
    {
        // Extension method to check if an integer is even
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }
}
