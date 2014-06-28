using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
{
    // Simple class to represent a Bank Customer. The customer has a first name and last name. 
    // The customer also has a BankAccountCollection that may contain multiple BankAccount objects.
    // All transactions made on the Customer's BankAccounts are stored in a TransactionCollection.
    public class Customer
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value != string.Empty && value.Length > 0)
                {
                    firstName = value;
                }
            }

        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value != string.Empty && value.Length > 0)
                {
                    lastName = value;
                }
            }

        }

        private BankAccountCollection accounts;
        public BankAccountCollection Accounts
        {
            get { return accounts; }
        }

        private TransactionCollection transactions;



        public Customer()
        {
            accounts = new BankAccountCollection();
            transactions = new TransactionCollection();

        }

        public void AddBankAccount(BankAccount bankAccount)
        {
            if (bankAccount != null)
            {
                accounts.Add(bankAccount);
            }
        }

        public void AddTransaction(Transaction newTransaction)
        {
            transactions.Add(newTransaction);
        }

        public string PrintTransactions(bool detailedView)
        {
            return transactions.Print(detailedView);
        }

        public bool ProcessTransactions()
        {
            return transactions.ProcessPendingTransactions();
        }

    }
}
