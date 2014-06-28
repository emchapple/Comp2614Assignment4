using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
{
    // Exception class to represent when an account does not have enough funds 
    // to fulfill the requested Transaction.

    public class NoSufficientFundsException : Exception
    {
        private BankAccount account;
        private decimal transactionAmount;

        public NoSufficientFundsException(BankAccount account, decimal transactionAmount)
            : base("There are not sufficient funds to perform this transaction.")
        {
            this.account = account;
            this.transactionAmount = transactionAmount;
        }

        public BankAccount Account { get { return account; } }

        public decimal TransactionAmount { get { return transactionAmount; } }
    }

    // Exception class to represent when a transaction amount is invalid, for example if it is a negative value

    public class InvalidTransactionAmtException : Exception
    {
        private decimal transactionAmount;

        public InvalidTransactionAmtException( decimal transactionAmount)
            : base("Invalid transaction amount.")
        {
            
            this.transactionAmount = transactionAmount;
        }


        public decimal TransactionAmount { get { return transactionAmount; } }
    }

    // Exception class to represent the case when the two accounts involved in a transfer
    // are the same.

    public class TransferFundsException : Exception
    {
        private BankAccount fromAccount;
        private BankAccount toAccount;
        private decimal transactionAmount;

        public TransferFundsException(BankAccount fromAccount, BankAccount toAccount,  decimal transactionAmount)
            : base("The two accounts selected for a transfer must be different.")
        {
            this.fromAccount = fromAccount;
            this.toAccount = toAccount;
            this.transactionAmount = transactionAmount;
        }

        public BankAccount FromAccount { get { return fromAccount; } }
        public BankAccount ToAccount { get { return toAccount; } }
        public decimal TransactionAmount { get { return transactionAmount; } }
    }

    // Exception class to represent the case when the requested BankAccount is not acitve.
    public class AccountInactiveException : Exception
    {
        private BankAccount account;

        public AccountInactiveException(BankAccount account)
            : base("The requested account is inactive.")
        {
            this.account = account;
           
        }

        public BankAccount Account { get { return account; } }

      
    }



}
