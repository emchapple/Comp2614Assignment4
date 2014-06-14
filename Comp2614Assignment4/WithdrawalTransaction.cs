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
        }

        public WithdrawalTransaction(BankAccount account, decimal amount )
        {
            this.Account = account;
            this.Amount = amount;
        }

        public override void DoTransaction()
        {
                validateBasics();
                validateAccountHasFunds();
                Process();
        }

        public override void Process()
        {
            Account.Withdraw(Amount);
            this.Status = TransactionStatus.Complete;
        }

        private bool validateAccountHasFunds()
        {
            return (this.Account.Balance >= Amount);
        }
    }
}
