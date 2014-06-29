using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
{
    // A DepositTransaction is a Transaction that handles depositing money into a BankAccount.
    // The DepositTransaction is created at the time of the deposit request, but the deposit is not carried out
    // until a hold period has elapsed.

    public class DepositTransaction : Transaction
    {
        private static int DELAY_IN_SECONDS = 30;

        public DepositTransaction()
        {
            setTimeStampToNow();
            name = "Deposit";
        }

        public DepositTransaction(BankAccount account, decimal amount )
        {
            this.Account = account;
            this.Amount = amount;
            setTimeStampToNow();

        }

        public override void DoTransaction()
        {
            validateBasics();
            this.Status = TransactionStatus.Pending;
        }

       
        public override bool Process()
        {
           
            if ( transactionDelayHasElapsed())
            {
                Account.Deposit(Amount);
                this.Status = TransactionStatus.Complete;
                return true;
            }
            return false;
        }

        private bool transactionDelayHasElapsed()
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan difference = currentTime - Timestamp;
            return difference.Seconds >= DELAY_IN_SECONDS;

        }
    


     }
}
