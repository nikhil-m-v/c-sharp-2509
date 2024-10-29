using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Engine
    {
        public int HorsePower { get; set; }

        public Engine(int horsePower)
        {
            HorsePower = horsePower;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Engine HorsePower: {HorsePower}");
        }
    }

    class Caar
    {
        public string Model { get; set; }
        public Engine CarEngine { get; set; }

        public Caar(string model, Engine engine)
        {
            Model = model;
            CarEngine = engine;
        }

        public void ShowCarDetails()
        {
            Console.WriteLine($"Car Model: {Model}");
            CarEngine.ShowDetails();
        }
    }
}
