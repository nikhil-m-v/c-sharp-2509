using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Circle
    {
        private double radius;
        const double PI = Math.PI;
        public double Radius 
        {  
            get { return radius; }
            set 
            {
                if (value < 0) 
                {
                    throw new ArgumentException("Radius cannot be negative");
                    
                }
            radius = value;
            } 
        }
        public Circle()
        {
            Radius = radius;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

    }
}
