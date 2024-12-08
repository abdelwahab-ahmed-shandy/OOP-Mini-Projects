using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class BankAccount
    {
        private int accountNumber;
        private string ownerName;
        private double balance;

        public int AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Error Enter the account number correctly");
                else
                    accountNumber = value;
            }
        }

        public string OwnerName
        {
            get { return ownerName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Error Enter Owner Name correctly");
                else
                    ownerName = value;
            }
        }

        public double Balance
        {
            get { return balance; }
        }

        public void Deposit(double value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Error: Deposit amount must be positive");
            balance = balance + value;
        }

        public void Withdraw(double value)
        {
            if (value > balance)
                throw new ArgumentOutOfRangeException("Error: Withdrawal is greater than the balance");
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Error: Withdrawal amount must be positive");
            balance = balance - value;
        }
        public void PrintInfoAccont()
        {
            Console.WriteLine("\n\t(The Account Info)");
            Console.WriteLine($"Accont Number : {AccountNumber}");
            Console.WriteLine($"Owner Name : {OwnerName}");
            Console.WriteLine($"Balance : {Balance}");
        }
    }
}
