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

        public string Print()
        {
            string output = "";
            foreach (Transaction transaction in transactions)
            {
                output += transaction.ToString();
            }
            return output;
        }

    }
}
