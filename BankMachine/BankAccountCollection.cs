using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
{
    // A BankAccountCollection is a list of BankAccounts The class inherits all methods from List. 
    // Its main purpose is to make the syntax nicer at the calling level.
    public class BankAccountCollection : List<BankAccount>
    {


        public void ValidateActive()
        {
            foreach (BankAccount account in this)
            {
                if (account.Active == false)
                {
                    throw new AccountInactiveException(account);
                }
            }
        }

    }
}
