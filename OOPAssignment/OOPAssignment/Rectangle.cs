using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Rectangle
    {
        public void CalculateArea(int length,int breadth) 
        {
            int area = length*breadth;
            Console.WriteLine($"Area of rectangle :{area}");
        }

        public void CalculateArea(int side) 
        {
            int area = side * side;
            Console.WriteLine($"Area of square :{area}");
        }
    }
}
