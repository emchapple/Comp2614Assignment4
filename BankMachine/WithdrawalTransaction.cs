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
            this.Accounts = new BankAccountCollection();
            Accounts.Add(account);
            this.Amount = amount;
            setTimeStampToNow();

        }

        public override void DoTransaction()
        {
            validateBasics();
            validateFunds();
            BankAccount account = Accounts.ElementAt(0);
            account.Withdraw(Amount);
            this.Status = TransactionStatus.Complete;
        }
            
        

        protected void validateFunds()
        {
            BankAccount account = Accounts.ElementAt(0);

            if (account.GetAvailableFunds() < Amount)
            {
                throw new NoSufficientFundsException(account, Amount);
            }
        }

        // No special behaviour defined that requires this implementation.

        public override bool Process()
        {
            return false;
        }



    }
}
