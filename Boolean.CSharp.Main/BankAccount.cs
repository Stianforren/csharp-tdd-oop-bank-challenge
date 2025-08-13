using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public abstract class BankAccount
    {
        private List<Payment> _payments = new List<Payment>();
        private Type _accountType;

        public BankAccount(Type accountType)
        {
            this._accountType = accountType;
        }

        public List<Payment> GetPaymentHistory() => _payments;
        public Type AccountType => _accountType;
    }
}
