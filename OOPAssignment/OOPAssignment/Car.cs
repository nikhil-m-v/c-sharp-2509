using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Car
    {
        private static int counter;
        public Car()
        {
            counter++;
            Console.WriteLine($"{counter} th object created");
        }

        static Car() 
        {
            counter = 0;
        }
    }
}
