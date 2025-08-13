using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public abstract class BankAccount
    {
        private List<Statements> _payments;
        public Guid ID { get; set; }

        public BankAccount()
        {
            _payments = new List<Statements>();
        }

        public void addStatement(StatementType st, decimal amount)
        {
            Statements statement = new Statements(st, amount);
            _payments.Add(statement);
        }

        public List<Statements> GetPaymentHistory() => _payments;

        public string printPaymentHistory()
        {
            List<string> strings = new List<string>();
            StringBuilder sb = new StringBuilder();
            decimal tempBalance = 0;
            sb.AppendLine($"date                  || credit || debit || balance");
            foreach (var item in _payments)
            {   
                if (item.StatementType == StatementType.Deposit)
                {
                    tempBalance += item.Amount;
                    strings.Add($"{item.Created} ||  {item.Amount,-2}  ||       ||{tempBalance,5}");
                }
                else
                {
                    tempBalance -= item.Amount;
                    strings.Add($"{item.Created} ||        ||  {item.Amount,-5}||{tempBalance,5}");
                }
            }
            foreach (var item in strings.OrderByDescending(x => x.Index()))
            {
                sb.AppendLine(item.ToString());
            }
            ;
            return sb.ToString();
        }
    }
}
