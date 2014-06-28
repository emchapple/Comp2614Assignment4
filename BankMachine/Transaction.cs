using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
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
        public abstract bool Process();
        
        

        public void validateBasics()
        {
            if (Account.Active == false)
            {
                throw new AccountInactiveException(Account);
            }
                
            if( Amount <= 0m)
            {
                throw new InvalidTransactionAmtException(Amount);

            }
           
        }

      

        protected void setTimeStampToNow()
        {
            timestamp = DateTime.Now;
        }

        public abstract string Print(bool detailedView);


    }
}
