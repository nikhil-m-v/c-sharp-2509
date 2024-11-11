using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    static class MathOperation
    {
        public static void Add(int a, int b) 
        {
            Console.WriteLine($"Result: {a+b}");
        }

        public static void Multiply(int a, int b)
        {
            Console.WriteLine($"Result: {a * b}");
        }
    }
    
}
