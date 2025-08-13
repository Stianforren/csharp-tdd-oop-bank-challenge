using Boolean.CSharp.Main;
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
            person.AddAccount(AccountType.Default);

            Assert.That(person.BankAccount != null);

        }

    }
}