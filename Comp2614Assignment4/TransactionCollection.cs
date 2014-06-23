using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp2614Assignment4
{
    public class TransactionCollection
    {

        private List<Transaction> transactions;

        public TransactionCollection()
        {
            transactions = new List<Transaction>();
        }

        public void Add(Transaction newTransaction)
        {
            transactions.Add(newTransaction);
        }

        public string Print(bool detailedView)
        {
            string output = "";
            foreach (Transaction transaction in transactions)
            {
                output += transaction.Print(detailedView);
            }
            return output;
        }

        public bool ProcessPendingTransactions()
        {
            bool changed = false;
            if (transactions.Count > 0)
            {
                foreach (Transaction transaction in transactions)
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
