using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp2614Assignment4
{
    public class DepositTransaction : Transaction
    {

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
            if (validateBasics())
            {
                Process();
            }
       }

        public override void Process()
        {
            Account.Deposit(Amount);
            this.Status = TransactionStatus.Complete;
        }

        public override string Print()
        {
            StringBuilder display = new StringBuilder(1000);
            {
                display.Append(Timestamp.ToString("d"));
                display.Append(" Deposit\r\n");
                display.AppendFormat("   To account: {0}\r\n", Account.Number);
                display.AppendFormat("   Amount: ${0:N2}\r\n", Amount);
            }
            return display.ToString();
        }



     }
}
