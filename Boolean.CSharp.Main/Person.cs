using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Person
    {
        public Guid person_id = Guid.NewGuid();
        private Role _role;
        private BankAccount? _bankAccount;
        private BankAccount? _savingsAccount;

        public Person(Role role = Role.Customer)
        {
            this._role = role;
        }
        public BankAccount BankAccount { get { return _bankAccount; } set { } }


        public void AddAccount(AccountType accountType)
        {
            if (accountType == AccountType.Default)
            {
            }


        }
    }
}
