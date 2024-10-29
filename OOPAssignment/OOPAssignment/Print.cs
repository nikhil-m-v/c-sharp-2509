using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Print
    {

        public void PrintData(string data)
        {
            Console.WriteLine("String: " + data);
        }

        public void PrintData(int data)
        {
            Console.WriteLine("Integer: " + data);
        }

        public void PrintData(int[] data)
        {
            Console.WriteLine("Array of integers: ");
            foreach (int num in data)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

    }
}
