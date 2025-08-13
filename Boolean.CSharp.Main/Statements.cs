using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Statements
    {
        private DateTime _created;
        private StatementType _StatementType;
        private decimal _amount;
        public Statements(StatementType statementType, decimal amount)
        {
            this._created = DateTime.Now;
            this._StatementType = statementType;
            this._amount = amount;
        }

        public DateTime Created { get { return _created; } }
        public StatementType StatementType { get { return _StatementType; } }
        public decimal Amount { get { return _amount; } }
        
    }
}
