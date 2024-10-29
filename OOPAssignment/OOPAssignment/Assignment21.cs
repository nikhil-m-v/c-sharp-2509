using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Banks
    {
        private List<Customer> customers = new List<Customer>();

        public void AddCustomer(string customerName)
        {
            Customer newCustomer = new Customer(customerName);
            customers.Add(newCustomer);
            Console.WriteLine($"Customer '{customerName}' added.");
        }

        public void AddAccount(string customerName, int accountNumber, decimal initialBalance)
        {
            Customer foundCustomer = customers.Find(c => c.Name == customerName);

            if (foundCustomer != null)
            {
                foundCustomer.AddAccount(accountNumber, initialBalance);
                Console.WriteLine($"Account '{accountNumber}' added to customer '{customerName}'.");
            }
            else
            {
                Console.WriteLine($"Customer '{customerName}' not found.");
            }
        }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine("\nCustomer Account Details:");

            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Customer: {customer.Name}");
                customer.DisplayAccounts();
            }
        }

        public class Customer
        {
            public string Name { get; private set; }
            private List<Account> accounts = new List<Account>();

            public Customer(string name)
            {
                Name = name;
            }

            public void AddAccount(int accountNumber, decimal balance)
            {
                Account newAccount = new Account(accountNumber, balance);
                accounts.Add(newAccount);
            }

            public void DisplayAccounts()
            {
                foreach (Account account in accounts)
                {
                    Console.WriteLine($"\tAccount Number: {account.AccountNumber}, Balance: {account.Balance:C}");
                }
            }

            public class Account
            {
                public int AccountNumber { get; private set; }
                public decimal Balance { get; private set; }

                public Account(int accountNumber, decimal balance)
                {
                    AccountNumber = accountNumber;
                    Balance = balance;
                }
            }
        }
    }
}

