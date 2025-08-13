using Boolean.CSharp.Main;
using Boolean.CSharp.Main.Accounts;
using NUnit.Framework;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private Core _core;

        public CoreTests()
        {
            _core = new Core();

        }

        [Test]
        public void TestAddAccount()
        {
            Person person = new Person();
            person.AddAccount(AccountType.Default, Branch.Bergen);

            Assert.That(person.BankAccounts != null);

        }

        [Test]
        public void TestDeposit()
        {
            Person person = new Person();
            person.AddAccount(AccountType.Default, Branch.Bergen);

            Guid id = person.BankAccounts.First().Key;

            person.BankAccounts[id].deposit(1000);

            Assert.That(person.BankAccounts[id].getBalance() == 1000);
            person.BankAccounts[id].deposit(1000);
            Assert.That(person.BankAccounts[id].getBalance() == 2000);
        }

        [Test]
        public void TestWithdraw()
        {
            Person person = new Person();
            person.AddAccount(AccountType.Default, Branch.Bergen);

            Guid id = person.BankAccounts.First().Key;

            person.BankAccounts[id].deposit(1000);

            Assert.That(person.BankAccounts[id].getBalance() == 1000);
            person.BankAccounts[id].withdraw(500);
            Assert.That(person.BankAccounts[id].getBalance() == 500);
        }

        [Test]
        public void TestAccountHasBranch()
        {
            Person person = new Person();
            person.AddAccount(AccountType.Default, Branch.Bergen);

            Guid id = person.BankAccounts.First().Key;
            Assert.That(person.BankAccounts[id].Branch == Branch.Bergen);
        }

        [Test]
        public void TestGenerateBankStatement()
        {
            Person person = new Person();
            person.AddAccount(AccountType.Default, Branch.Bergen);

            Guid id = person.BankAccounts.First().Key;
            BankAccount bk = person.BankAccounts[id];

            bk.deposit(1000);
            bk.deposit(3000);

            Assert.That(bk.GetPaymentHistory().Count == 2);

        }

        [Test]
        public void TestRequestOverdraft()
        {
            Person person = new Person();
            person.AddAccount(AccountType.Default, Branch.Bergen);

            Guid id = person.BankAccounts.First().Key;
            BankAccount bk = person.BankAccounts[id];

            person.requestOverdraft(bk);
            Assert.IsTrue(bk.overdraftRequested());
        }
    }
}