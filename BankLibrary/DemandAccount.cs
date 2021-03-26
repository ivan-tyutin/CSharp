﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    class DemandAccount : Account
    {
        public DemandAccount(decimal sum, int percantage) : base(sum, percantage)
        {
        }

        protected internal override void Open()
        {
            base.OnOpened(new AccountEventArgs($"Открыт новый счет до востребования! Id счета {this.Id}", this.Sum));
        }

    }
}
