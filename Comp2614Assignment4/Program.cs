using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankMachine;

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

        // Seed the program with some sample data.
        // For a real application, the customer would be created from 
        // another form and start with zero balances.
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
