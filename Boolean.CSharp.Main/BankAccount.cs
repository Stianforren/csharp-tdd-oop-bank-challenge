using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public abstract class BankAccount
    {
        private List<Payment> _payments;
        public Guid ID { get; set; }
        //private Type _accountType;

        public BankAccount()
        {
            _payments = new List<Payment>();
            //this._accountType = accountType;
        }

        public List<Payment> GetPaymentHistory() => _payments;
    }
}
