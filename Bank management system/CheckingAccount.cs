using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_management_system
{
    public class CheckingAccount : SavingsAccount
    {
        const double Fee = 1.50;
        public CheckingAccount(string name = "Null", double balance = 0) : base(name, balance)
        {
            balance = balance - Fee;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Balance after fees : {Balance - Fee}";
        }
    }
}
