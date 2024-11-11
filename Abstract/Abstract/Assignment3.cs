using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    interface IDrive
    {
        void Drive();
    }
    public class Cars : IDrive
    {
        public void Drive() 
        {
            Console.WriteLine("Car is driving");
        }
    }
    public class Truck 
    {
        public void Drive() 
        {
            Console.WriteLine("Truck is driving");
        }
    }
}
