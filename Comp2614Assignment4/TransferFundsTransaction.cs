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
            setTimeStampToNow();
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

        //public override string Print()
        //{
        //    StringBuilder display = new StringBuilder(1000);
        //    {
        //        display.Append(this.Timestamp.ToString("d"));
        //        display.AppendFormat("From account: {0}\n", Account.NameAndNumberDisplay);
              
        //    }
        //    return display.ToString();
        //}

        public override string Print()
        {
            StringBuilder display = new StringBuilder(1000);
            {
                display.Append(Timestamp.ToString("d"));
                display.Append(" Transfer\r\n");
                display.AppendFormat("   From account: {0}\r\n", Account.Number);
                display.AppendFormat("   To account: {0}\r\n", ToAccount.Number);
                display.AppendFormat("   Amount: ${0:N2}\r\n", Amount);
            }
            return display.ToString();
        }



        //private bool validateAccountHasFunds()
        //{
        //    return (this.Account.GetAvailableFunds() >= Amount);
        //}
    }
}


