// See https://aka.ms/new-console-template for more information

var account = new BankAccount("IVAN", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
Console.ReadLine();
