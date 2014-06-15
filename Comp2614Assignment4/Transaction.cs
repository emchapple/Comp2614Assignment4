using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp2614Assignment4
{
    public abstract class Transaction
    {
        public enum TransactionStatus { Pending, Complete };

        private DateTime timestamp;
        public DateTime Timestamp
        {
            get { return timestamp; }
        }
        public BankAccount Account { get; set; }

        public decimal Amount { get; set; }

        public TransactionStatus Status {get; set;}
                  

        public abstract void DoTransaction();
        public abstract void Process();
        public bool validateBasics()
        {
            if (Account.Active && Amount > 0m)
            {
                return true;
            }
            return false;
        }

        protected bool validateAccountHasFunds()
        {
            decimal availableFunds = this.Account.GetAvailableFunds();
            return (availableFunds >= Amount);
        }

    }
}
