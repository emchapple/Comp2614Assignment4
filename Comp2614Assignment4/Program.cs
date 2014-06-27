using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp2614Assignment4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BankAccount.initialize();
            Customer customer = createCustomer();
 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain(customer));

        }

        private static Customer createCustomer()
        {
            Customer customer = new Customer();
            customer.FirstName = "Freida";
            customer.LastName = "Franklin";

            decimal savingsAccountBalance = 2000m;
            SavingsAccount savingsAccount = new SavingsAccount(savingsAccountBalance);
            customer.AddBankAccount(savingsAccount);

            decimal creditLimit = 10000m;
            decimal creditLimitBalance = -3456m;
            CreditLine creditLineAccount = new CreditLine(creditLimit, creditLimitBalance);
            customer.AddBankAccount(creditLineAccount);

            decimal savingsAccountBalance2 = 3502m;
            SavingsAccount savingsAccount2 = new SavingsAccount(savingsAccountBalance2);
            customer.AddBankAccount(savingsAccount2);

         

            
            return customer;
        }  

    }
}
