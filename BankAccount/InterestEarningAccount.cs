

    //Счет для начисления процентов:
    //Будут начисляться 2 % от текущего баланса в конце месяца.

    public class InterestEarningAccount : BankAccount 
    {
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {
        }

        public override void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
            {
                decimal interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "apply monthly interest");
            }
        }
    }

