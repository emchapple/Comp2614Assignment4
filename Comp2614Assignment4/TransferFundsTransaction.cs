using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp2614Assignment4
{
    public class TransferFundsTransaction : Transaction
    {
        public BankAccount ToAccount{get; set;}

        public TransferFundsTransaction()
        {
        }

        public TransferFundsTransaction(BankAccount fromAccount, BankAccount toAccount, decimal amount )
        {
            this.Account = fromAccount;
            this.ToAccount = toAccount;
            this.Amount = amount;
        }

        public override void DoTransaction()
        {
            if (validateBasics() && validateAccountHasFunds())
            {
                Process();
            }
        }

        public override void Process()
        {
            Account.TransferTo(ToAccount, Amount);
            this.Status = TransactionStatus.Complete;
        }

        //private bool validateAccountHasFunds()
        //{
        //    return (this.Account.GetAvailableFunds() >= Amount);
        //}
    }
}


