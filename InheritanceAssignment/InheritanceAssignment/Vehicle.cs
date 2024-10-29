using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public interface IMovable 
    {
        void Move();
    }

    public interface IRechargable
    {
        void Recharge();
    }
    public class Vehicle: IMovable, IRechargable
    {
        public void Move()
        {
            Console.WriteLine("Vehicle is moving");
        }

        public void Recharge()
        {
            Console.WriteLine("Vehicle is recharging");
        }
    }

    public class ElectricCar : Vehicle 
    {
        public void CarInfo()
        {
            Console.WriteLine("This is electric car");
        }
    }
}
