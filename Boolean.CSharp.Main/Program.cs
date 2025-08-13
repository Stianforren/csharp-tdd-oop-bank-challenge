using Boolean.CSharp.Main;

Person person = new Person();
person.AddAccount(AccountType.Default);
Guid id = person.BankAccounts.First().Key;

person.BankAccounts[id].addStatement(StatementType.Deposit, 1000);
person.BankAccounts[id].addStatement(StatementType.Deposit, 2000);
person.BankAccounts[id].addStatement(StatementType.Withdraw, 500);
person.BankAccounts[id].addStatement(StatementType.Withdraw,1000);

Console.WriteLine(person.BankAccounts[id].printPaymentHistory());