using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp2614Assignment4
{
    public class DepositTransaction : Transaction
    {
        private static int DELAY_IN_SECONDS = 30;

        public DepositTransaction()
        {
            setTimeStampToNow();
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
    

        public override string Print(bool detailedView)
        {
            StringBuilder display = new StringBuilder(1000);
            {
                display.Append(Timestamp.ToString("d"));
                display.Append(" Deposit");
                if (Status == TransactionStatus.Pending)
                {
                    display.Append(" [Pending]");
                }
                display.Append("\r\n");
                if (detailedView)
                {
                    display.AppendFormat("   To account: {0}\r\n", Account.Number);
                    display.AppendFormat("   Amount: ${0:N2}\r\n", Amount);
                }
            }
            return display.ToString();
        }



     }
}
