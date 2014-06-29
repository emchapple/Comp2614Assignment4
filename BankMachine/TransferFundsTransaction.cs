using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
{
    // TransferFundsTransaction is a WithdrawalTransaction that also deposits the amount to another account.
    // ToAccount is the account that the funds will be transferred to.
    // The from account is the account inherited from the WithdrawalTransaction.

    public class TransferFundsTransaction : WithdrawalTransaction
    {
        private BankAccount toAccount;
        public BankAccount ToAccount
        {
            get
            { return toAccount; }

            set
            {
                if (value != null)
                {
                    toAccount = value;
                }
            }
        }

        public TransferFundsTransaction()
        {
            setTimeStampToNow();
            name = "Transfer Funds";
        }

        public void validateAccounts()
        {
            if(toAccount == Account)
            {
                throw new TransferFundsException(Account, toAccount, Amount);
            }
        }

        public override void DoTransaction()
        {
            validateBasics();
            validateFunds();
            validateAccounts();
              
            Account.TransferTo(toAccount, Amount);
            this.Status = TransactionStatus.Complete;
    
        }




    }
}


