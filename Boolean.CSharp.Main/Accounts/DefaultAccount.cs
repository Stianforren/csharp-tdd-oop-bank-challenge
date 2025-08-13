using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Accounts
{
    public class DefaultAccount : BankAccount
    {
        private decimal _balance;
        public DefaultAccount(Branch branch) : base(branch)
        {
            this._balance = 0;
        }
        public decimal balance => _balance;

    }
}
