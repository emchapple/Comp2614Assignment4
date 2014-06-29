using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
{
    // This class takes care of handling modifications to BankAccount balances. 
    // A Transaction must implement DoTransaction and Process methods.
    // This allows the implentation class to separate different processes that could be done at different times.
    // For example, if a hold is to be placed on a deposit transaction, DoTransaction records the transaction
    // request and Process is used to process the transaction once the deposit funds have been verified.

    // Transactions have a timestamp, BankAccountCollection, and the amount of money to be processed.
    // The BankAccountCollection can only have one or two accounts in it. Two is for tranferring, 
    // deposit and withdrawal only need one.
    // Transactions cannot be carried out on inactive accounts or with negative amounts of money.
    // Transactions must also have a Print method to display the transaction details.

    public abstract class Transaction
    {
        public enum TransactionStatus { Pending, Complete };

        private DateTime timestamp;
        public DateTime Timestamp
        {
            get { return timestamp; }
        }

        private BankAccountCollection accounts;
        public BankAccountCollection Accounts
        {
            get
            {
                return accounts;
            }

            set
            {
                if (value != null && value.Count <= 2)
                {
                    accounts = value;
                }
            }
        }

   

        private decimal amount;
        public decimal Amount
        {
            get
            {
                return amount;
            }

            set
            {
                if (value != null)
                {
                    amount = value;
                }
            }
        }

        private TransactionStatus status;
        public TransactionStatus Status
        {
            get
            {
                return status;
            }
            set
            {
                if (value != null)
                {
                    status = value;
                }
            }
        }

        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
 
        public abstract void DoTransaction();
        public abstract bool Process();
        
        // Make sure that the account is active and the amount is valid.
        // Can throw an AccountInactiveException or InvalidTransactionAmtException.
        public void validateBasics()
        {
            validateAcitve();
            validateAmount();  
        }

        private void validateAcitve()
        {
            accounts.ValidateActive();
          
        }


        private void validateAmount()
        {
            if (Amount <= 0m)
            {
                throw new InvalidTransactionAmtException(Amount);
            }
        }

        protected void setTimeStampToNow()
        {
            timestamp = DateTime.Now;
        }

     
    }
}
