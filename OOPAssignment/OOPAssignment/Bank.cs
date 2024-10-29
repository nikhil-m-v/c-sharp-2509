using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Bank
    {
        private int balance {  get; set; }
        private static int interestRate;
        static Bank()
        {
            interestRate = 5;
            Console.WriteLine($"Static Interest rate : {interestRate}");
        }

        public Bank(int Balance)
        {
            balance = Balance;
            Console.WriteLine($"Balance : {balance}");
        }
        
    }
}
