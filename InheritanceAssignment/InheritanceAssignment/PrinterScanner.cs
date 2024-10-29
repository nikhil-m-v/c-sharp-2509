using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    interface IPrintable 
    {
        void Print();
    }

    interface IScannable 
    {
        void Scan();
    }

    class PrinterScanner : IPrintable, IScannable
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }
    }
}
