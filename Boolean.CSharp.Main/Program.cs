using Boolean.CSharp.Main;
using Boolean.CSharp.Main.Persons;

Person person = new NormalPerson();
person.AddAccount(AccountType.Default, Branch.Bergen);
Guid id = person.BankAccounts.First().Key;

person.BankAccounts[id].deposit(1000);
person.BankAccounts[id].deposit(2000);
person.BankAccounts[id].withdraw(500);

Console.WriteLine(person.BankAccounts[id].printPaymentHistory());