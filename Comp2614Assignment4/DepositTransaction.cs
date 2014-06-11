using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp2614Assignment4
{
    public class DepositTransaction : Transaction
    {

        public DepositTransaction(BankAccount account, decimal amount )
        {
            this.bankAccount = account;
            this.amount = amount;
        }

        public override void DoTransaction()
        {
        
                validateBasics();
                Process();


        }

        public override void Process()
        {
            bankAccount.Deposit(amount);
            this.Status = TransactionStatus.Complete;
        }

    }
}
