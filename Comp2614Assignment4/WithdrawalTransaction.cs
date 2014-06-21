using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp2614Assignment4
{
    public class WithdrawalTransaction : Transaction
    {

        public WithdrawalTransaction()
        {
            setTimeStampToNow();
        }

        public WithdrawalTransaction(BankAccount account, decimal amount )
        {
            this.Account = account;
            this.Amount = amount;
            setTimeStampToNow();

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
                Process();
            }
            
        }

        public override void Process()
        {
            Account.Withdraw(Amount);
            this.Status = TransactionStatus.Complete;
        }


        public override string Print()
        {
            StringBuilder display = new StringBuilder(1000);
            {
                display.Append(Timestamp.ToString("d"));
                display.Append(" Withdrawal\r\n");
                display.AppendFormat("   From account: {0}\r\n", Account.Number);
                display.AppendFormat("   Amount: ${0:N2}\r\n", Amount);
            }
            return display.ToString();
        }

    }
}
