using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }

    // Abstract class Shape
    public abstract class Shapee : IShape
    {
        // Abstract methods for area and perimeter
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        // A non-abstract method to describe the shape
        public void Describe()
        {
            Console.WriteLine($"This is a {this.GetType().Name}.");
        }
    }

    // Derived class Circle implementing Shape
    public class Circlee : Shapee
    {
        public double Radius { get; set; }

        public Circlee(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    // Derived class Rectangle implementing Shape
    public class Rectanglee : Shapee
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectanglee(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }
}
