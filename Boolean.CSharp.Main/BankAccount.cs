using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public abstract class BankAccount
    {
        private List<Statement> _payments;
        private Branch _branch;
        public Guid ID { get; set; }

        public BankAccount(Branch branch)
        {
            _payments = new List<Statement>();
            _branch = branch;
        }

        public List<Statement> GetPaymentHistory() => _payments;
        public Branch Branch { get { return _branch; } }

        public string printPaymentHistory()
        {
            Dictionary<int,string> strings = new Dictionary<int,string>();
            StringBuilder sb = new StringBuilder();
            decimal tempBalance = 0;
            sb.AppendLine($"date                 || credit || debit || balance");
            int counter = 0;
            foreach (var item in _payments)
            {
                if (item.StatementType == StatementType.Deposit)
                {
                    tempBalance += item.Amount;
                    strings.Add(counter, $"{item.Created} ||  {item.Amount,-2}  ||       ||{tempBalance,5}");
                }
                else
                {
                    tempBalance -= item.Amount;
                    strings.Add(counter, $"{item.Created} ||        ||  {item.Amount,-5}||{tempBalance,5}");
                }
                counter++;
            }

            foreach (var item in strings.OrderByDescending(x => x.Key))
            {
                sb.AppendLine(item.Value);
            }
            return sb.ToString();
        }

        public decimal getBalance()
        {
            return _payments.Sum(x => x.StatementType == StatementType.Deposit ? x.Amount : -x.Amount);
        }

        public void deposit(decimal amount)
        {
            _payments.Add(new Statement(StatementType.Deposit, amount));
        }

        public void withdraw(decimal amount)
        {
            _payments.Add(new Statement(StatementType.Withdraw, amount));
        }
    }
}
