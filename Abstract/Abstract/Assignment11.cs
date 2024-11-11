using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public enum CarType
    {
        Sedan,
        SUV,
        Truck,
        Coupe
    }

    public class Carr
    {
        public CarType Type { get; set; }

        public Carr(CarType type)
        {
            Type = type;
        }

        public void DisplayCarMessage(CarType type)
        {
            switch (type)
            {
                case CarType.Sedan:
                    Console.WriteLine("Sedan: A comfortable car ideal for city and highway driving.");
                    break;
                case CarType.SUV:
                    Console.WriteLine("SUV: Perfect for families and off-road adventures.");
                    break;
                case CarType.Truck:
                    Console.WriteLine("Truck: Built for heavy-duty tasks and cargo transport.");
                    break;
                case CarType.Coupe:
                    Console.WriteLine("Coupe: A stylish choice, great for sporty drives.");
                    break;
                default:
                    Console.WriteLine("Unknown car type.");
                    break;
            }
        }
    }

}
