using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public interface IMovable
    {
        void Move();
    }

    // IDrawable interface
    public interface IDrawable
    {
        void Draw();
    }

    // Car class implementing both IMovable and IDrawable interfaces
    public class Cars : IMovable, IDrawable
    {
        public string Model { get; set; }

        public Cars(string model)
        {
            Model = model;
        }

        // Implementation of IMovable interface method
        public void Move()
        {
            Console.WriteLine($"{Model} is moving.");
        }

        // Implementation of IDrawable interface method
        public void Draw()
        {
            Console.WriteLine($"Drawing {Model} on the screen.");
        }
    }
}
