﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp2614Assignment4
{
    public class DepositTransaction : Transaction
    {

        public DepositTransaction()
        {
        }

        public DepositTransaction(BankAccount account, decimal amount )
        {
            this.Account = account;
            this.Amount = amount;
        }

        public override void DoTransaction()
        {
            if (validateBasics())
            {
                Process();
            }
       }

        public override void Process()
        {
            Account.Deposit(Amount);
            this.Status = TransactionStatus.Complete;
        }

    }
}
