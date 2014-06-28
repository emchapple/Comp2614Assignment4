using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
{
    // WithdrawalTransaction is a Transaction that withdraws money from an account.
    // The selected BankAccount must have the requested funds.

    public class WithdrawalTransaction : Transaction
    {

        public WithdrawalTransaction()
        {
            setTimeStampToNow();
            name = "Withdrawal";
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
            validateFunds();
            Account.Withdraw(Amount);
            this.Status = TransactionStatus.Complete;
        }
            
        

        protected void validateFunds()
        {
            if (Account.GetAvailableFunds() < Amount)
            {
                throw new NoSufficientFundsException(Account, Amount);
            }
        }

        // No special behaviour defined that requires this implementation.

        public override bool Process()
        {
            return false;
        }


        public override void AppendDetails(StringBuilder display)
        {
            display.AppendFormat("   From account: {0}\r\n", Account.Number);
            display.AppendFormat("   Amount: ${0:N2}\r\n", Amount);
        }
    }
}
