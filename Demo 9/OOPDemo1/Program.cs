using OOPDemo1;

// Declare a bank account object for Sam and Mary
BankAccount samAccount = new BankAccount(1, "Sam", "1234", 0);
BankAccount maryAccount = new BankAccount(2, "Mary", "5678", 1000);

Console.WriteLine($"Before deposit: {samAccount.GetData()}");
samAccount.Deposit(500);
Console.WriteLine($"After deposit: {samAccount.GetData()}");
samAccount.Withdraw(200);
Console.WriteLine($"After withdraw: {samAccount.GetData()}");

Console.WriteLine(samAccount.Audit);