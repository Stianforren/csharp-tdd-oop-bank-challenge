using Boolean.CSharp.Main.Accounts;
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
        private Dictionary<Guid, BankAccount> _accounts;

        public Person(Role role = Role.Customer)
        {
            this._role = role;
            this._accounts = new Dictionary<Guid, BankAccount>();
        }
        public BankAccount bankAccount(Guid account)
        {
            try
            {
                return _accounts[account];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        public Dictionary<Guid, BankAccount> BankAccounts { get { return _accounts; } }
        public void AddAccount(AccountType accountType)
        {
            if (accountType.Equals(AccountType.Default))
            {
                BankAccount bankAccount = new DefaultAccount();
                _accounts.Add(bankAccount.ID, bankAccount);
            }
            else if (accountType.Equals(AccountType.Savings))
            {
                BankAccount savingsAccount = new SavingsAccount();
                _accounts.Add(savingsAccount.ID, savingsAccount);
            }
        }
    }
}
