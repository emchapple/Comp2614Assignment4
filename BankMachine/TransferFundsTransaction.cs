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
        public BankAccount ToAccount{get; set;}

        public TransferFundsTransaction()
        {
            setTimeStampToNow();
            name = "Transfer Funds";
        }

        public void validateAccounts()
        {
            if(ToAccount == Account)
            {
                throw new TransferFundsException(Account, ToAccount, Amount);
            }
        }

        public override void DoTransaction()
        {
            validateBasics();
            validateFunds();
            validateAccounts();
              
            Account.TransferTo(ToAccount, Amount);
            this.Status = TransactionStatus.Complete;
    
        }




    }
}


