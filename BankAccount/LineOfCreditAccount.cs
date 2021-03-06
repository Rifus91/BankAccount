
//Кредитная линия:
//Может иметь отрицательный баланс, который не превышает абсолютное значение кредитного лимита.
//Будут списываться проценты каждый месяц, в конце которого баланс не равен 0.
//Будет взиматься комиссия за каждый вывод средств, превышающий кредитный лимит.
public class LineOfCreditAccount : BankAccount
{


    public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit)
    {
    }

    public override void PerformMonthEndTransactions()
    {
        if (Balance < 0)
        {
            // Negate the balance to get a positive interest charge:
            decimal interest = -Balance * 0.07m;
            MakeWithdrawal(interest, DateTime.Now, "Charge mothly interest");
        }
    }


    protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
    isOverdrawn
    ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
    : default;


}

