using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp2614Assignment4
{
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

        private List<BankAccount> accounts;
        public List<BankAccount> Accounts
        {
            get { return accounts; }
        }

        private TransactionCollection transactions;



        public Customer()
        {
            accounts = new List<BankAccount>();
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

        public string PrintTransactions()
        {
            return transactions.Print();
        }

        public bool ProcessTransactions()
        {
            return transactions.ProcessPendingTransactions();
        }

    }
}
