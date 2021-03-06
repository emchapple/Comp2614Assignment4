﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
{
    // A class to represent a series of modifications to BankAccount balances.
    // The ProcessPendingTransactions method polls all the transactions in the collection
    // for pending transactions, and processes any found.

    public class TransactionCollection : List<Transaction>
    {
        //If any transactions are processed, returns true. Otherwise, false.
        public bool ProcessPendingTransactions()
        {
            bool changed = false;
            if (this.Count > 0)
            {
                foreach (Transaction transaction in this)
                {
                    if (transaction.Status == Transaction.TransactionStatus.Pending)
                    {
                        bool thisChanged = transaction.Process();
                        changed = changed || thisChanged;
                    }
                }
            }
            return changed;
        }
    }
}
