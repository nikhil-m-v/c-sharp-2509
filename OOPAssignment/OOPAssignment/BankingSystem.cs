using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    using System;
    using System.Collections.Generic;

    class BankingSystem
    {
        private string accountNumber;
        private string accountHolderName;
        private int balance;

        public BankingSystem(string accNumber, string accHolderName, int initialBalance)
        {
            accountNumber = accNumber;
            accountHolderName = accHolderName;
            Balance = initialBalance;
        }

        public int Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Error: Balance cannot be set to a negative value.");
                }
            }
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposit successful! New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Error: Deposit amount must be positive.");
            }
        }

        public void Withdraw(int amount)
        {
            if (amount > 0)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdrawal successful! New Balance: {Balance}");
                }
                else
                {
                    Console.WriteLine("Error: Insufficient balance.");
                }
            }
            else
            {
                Console.WriteLine("Error: Withdrawal amount must be positive.");
            }
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Holder: {accountHolderName}");
            Console.WriteLine($"Current Balance: {Balance}");
        }
    }
}
