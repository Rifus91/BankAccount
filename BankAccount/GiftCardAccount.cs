﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class GiftCardAccount : BankAccount
    {
        public GiftCardAccount(string name, decimal initialBalance) : base(name, initialBalance)
        { }
    }
}