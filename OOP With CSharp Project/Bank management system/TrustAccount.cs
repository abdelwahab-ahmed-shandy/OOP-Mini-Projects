using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_management_system
{
    public class TrustAccount : SavingsAccount
    {
        private int Count { get; set; }
        private DateTime OverTime { get; set; }

        public TrustAccount(string name = "null", double balance = 0, double interstRate = 0) : base(name, balance)
        {

        }

        public override bool Deposit(double amount)
        {
            if (amount >= 5000)
                Console.WriteLine($"Add Bouns {base.Deposit(50)} Account is {Name}");

            return base.Deposit(amount);
        }
        public override bool Withdraw(double amount)
        {
            if (DateTime.Now.Year != OverTime.Year && DateTime.Now.Month == OverTime.Month
                && DateTime.Now.Day == OverTime.Day)
            {
                OverTime = DateTime.Now;
                Count = 3;
                return base.Withdraw(amount);
            }
            if (Count <= 3 && Count >= 0 && amount <= (0.2 * Balance))
            {
                Count--;
                return base.Withdraw(amount);
            }
            return false;
        }
        public override string ToString()
        {
            return $"Trusted Account : {base.ToString()} Rate is {InterstRate}";
        }
    }
}
