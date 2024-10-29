using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    interface IDriveable
    {
        void Drive();
    }

    interface IRaceable : IDriveable
    {
        void Race();
    }
    class Cars : IRaceable
    {
        public void Drive()
        {
            Console.WriteLine("The car is driving");
        }

        public void Race()
        {
            Console.WriteLine("The car is racing");
        }
    }
}
