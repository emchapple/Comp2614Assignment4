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

        public TransferFundsTransaction()
        {
            setTimeStampToNow();
            name = "Transfer Funds";
        }

        public void validateAccounts()
        {
            BankAccount fromAccount = Accounts.ElementAt(0);
            BankAccount toAccount = Accounts.ElementAt(1);
            if (fromAccount == toAccount)
            {     
                throw new TransferFundsException(fromAccount, toAccount, Amount);
            }
        }

        public override void DoTransaction()
        {
            validateBasics();
            validateFunds();
            validateAccounts();
              
            Accounts.ElementAt(0).TransferTo(Accounts.ElementAt(1), Amount);
            this.Status = TransactionStatus.Complete;
    
        }




    }
}


