using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class MathOperations
    {
        private static double PI;

        static MathOperations() 
        {
            PI = Math.PI;
        }

        public void getPI() 
        {
            Console.WriteLine(PI);
        }
    }
}
