using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp2614Assignment4
{
    class Utils
    {


        public static string accountNameAndNumberDisplay(BankAccount account)
        {
            return string.Format("{0} {1}", account.Name, account.Number);
        }

        public static string accountCreditDisplay(BankAccount account)
        {
            string display = "N/A";
            CreditLine creditLine = account as CreditLine;
            if (creditLine != null)
            {
                display = creditLine.CreditLimit.ToString("N2");
            }
            return display;

        }
    }
}
