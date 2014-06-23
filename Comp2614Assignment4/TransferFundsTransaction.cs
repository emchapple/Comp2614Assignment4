using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp2614Assignment4
{
    public class TransferFundsTransaction : WithdrawalTransaction
    {
        public BankAccount ToAccount{get; set;}

        public TransferFundsTransaction()
        {
            setTimeStampToNow();
        }

        public void checkAccounts()
        {
            if(ToAccount == Account)
            {
                throw new TransferFundsException(Account, ToAccount, Amount);
            }
        }

        public override void DoTransaction()
        {
            validateBasics();
            if (Account.GetAvailableFunds() < Amount)
            {
                throw new NoSufficientFundsException(Account, Amount);
            }
            else
            {
                checkAccounts();
              
                Account.TransferTo(ToAccount, Amount);
                this.Status = TransactionStatus.Complete;
            }

        }

        public override bool Process()
        {
            return false;
        }
   

        public override string Print(bool detailedView)
        {
            StringBuilder display = new StringBuilder(1000);
            {
                display.Append(Timestamp.ToString("d"));
                display.Append(" Transfer\r\n");
                if (detailedView)
                {

                    display.AppendFormat("   From account: {0}\r\n", Account.Number);
                    display.AppendFormat("   To account: {0}\r\n", ToAccount.Number);
                    display.AppendFormat("   Amount: ${0:N2}\r\n", Amount);
                }
            }
            return display.ToString();
        }



    }
}


