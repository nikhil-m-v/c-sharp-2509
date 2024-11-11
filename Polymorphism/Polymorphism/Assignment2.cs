using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class MathOperations
    {
        public int Multiply(int a,int b) 
        {
            return a * b;
        }

        public int Multiply(int a, int b, int c) 
        {
            return a * b * c;
        }
    }
}
