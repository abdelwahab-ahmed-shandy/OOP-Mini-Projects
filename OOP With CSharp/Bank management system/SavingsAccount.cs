using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_management_system
{
    public class SavingsAccount : Account
    {
        public double InterstRate { get; set; }

        public SavingsAccount(string name = "null", double balance = 0.0, double interstRate = 0.0) : base(name, balance)
        {
            if (interstRate < 0)
                throw new Exception("Can Not Be Less Than Zero");
            InterstRate = interstRate;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Interest Rate: {InterstRate}";
        }
    }
}
