using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_5
{
    // Define a Circle struct (value type)
    public struct Circle
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Circle Radius: {Radius}");
        }
    }

    // Define a Shape class (reference type)
    public class Shape
    {
        public string ShapeName { get; set; }

        public Shape(string shapeName)
        {
            ShapeName = shapeName;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Shape Name: {ShapeName}");
        }
    }
}
