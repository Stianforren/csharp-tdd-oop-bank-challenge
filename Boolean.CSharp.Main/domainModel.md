|Classes| Methods/Properties|Scenario|Output|
|-------|-------------------|---------|------|
|Person.cs|CreateAccount(Type accountType)| so I can create a account|Creates an account of given type|
|BankAccount.cs|printPaymentHistory()|so i can see all my transactions|prints a overview over transactions made|
|BankAccount.cs|Deposit(decimal amount)|so i can deposit money|adds given amount to user|
|BankAccount.cs|Withdraw(decimal amount)|so i can withdraw money|removes given amount from user|
|BankAccount.cs|printPaymentHistory()|so i dont store balance in memory|utilizes transactionhistory to calucalte balance at given time|
|BankAccount.cs|BankAcount(Branch branch)|so every acount is assosiated with branch|provides each bankacount with a branch|
|Person.cs|requestOverdraft(BankAccount bk)|so i can have overdraft on my acount|sends request to account|
|BankAccount.cs|approve(Person person)|si i can approve or reject overdraft requests|true if manager, false otherwise|