﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing shape...");
        }
    }
    public class Circle : Shape 
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing circle...");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle...");
        }
    }
}
