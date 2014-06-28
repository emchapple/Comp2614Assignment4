using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
{
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

    public class TransferFundsException : Exception
    {
        private BankAccount fromAccount;
        private BankAccount toAccount;
        private decimal transactionAmount;

        public TransferFundsException(BankAccount fromAccount, BankAccount toAccount,  decimal transactionAmount)
            : base("The two accounts selected for a tranfer must be different.")
        {
            this.fromAccount = fromAccount;
            this.toAccount = toAccount;
            this.transactionAmount = transactionAmount;
        }

        public BankAccount FromAccount { get { return fromAccount; } }
        public BankAccount ToAccount { get { return toAccount; } }
        public decimal TransactionAmount { get { return transactionAmount; } }
    }

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
