// See https://aka.ms/new-console-template for more information

var account = new BankAccount("IVAN", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");


account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine();

Console.WriteLine($" текущий баланс {account.Balance}");
account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
Console.WriteLine($" текущий баланс {account.Balance}");


//BankAccount invalidAccount;
//try
//{
//    invalidAccount = new BankAccount("invalid", -55);
//}
//catch (ArgumentOutOfRangeException e)
//{
//    Console.WriteLine("Exception caught creating account with negative balance");
//    Console.WriteLine(e.ToString());
//    return;
//}


// Test for a negative balance.


Console.WriteLine(account.GetAccountHistory());
Console.ReadLine();

//Счет для начисления процентов:
//Будут начисляться 2 % от текущего баланса в конце месяца.
//Кредитная линия:
//Может иметь отрицательный баланс, который не превышает абсолютное значение кредитного лимита.
//Будут списываться проценты каждый месяц, в конце которого баланс не равен 0.
//Будет взиматься комиссия за каждый вывод средств, превышающий кредитный лимит.
//Счет для подарочной карты:
//Может пополняться на указанную сумму в последний день каждого месяца.




