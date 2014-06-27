using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp2614Assignment4
{
    public abstract class BankAccount
    {

        protected string name;
        public string Name
        {
            get { return name; }
        }

        protected int number;
        public int Number
        {
            get { return number; }
        }

        protected decimal balance;
        public decimal Balance
        {
            get { return balance; }
        }

        protected decimal minimumBalance;
        protected bool active;
        public bool Active
        {
            get { return active; }
        }

        private static int highestAccountNumber;

        public string NameAndNumberDisplay
        {
            get { return string.Format("{0} {1}", name, number); }
        }



        public BankAccount(decimal balance)
        {
            this.balance = balance;
            active = true;
            highestAccountNumber++;
            number = highestAccountNumber;

        }

        public static void initialize()
        {
            highestAccountNumber = 1000;
        }


        public void Deposit(decimal amountToAdd)
        {
            if (amountToAdd > 0)
            {
                balance += amountToAdd;
            }
        }

        public abstract void Withdraw(decimal amountToWithdraw);
       

        public void TransferTo(BankAccount toAccount, decimal amount)
        {
            Withdraw(amount);
            toAccount.Deposit(amount);    
        }
    }


    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(decimal balance) : base(balance)
        {
            minimumBalance = 0m;
            name = "Savings Account";
        }

     

        public override void Withdraw(decimal amount)
        {
            balance -= amount;
        }

    }

    public class CreditLine : BankAccount
    {
        private decimal creditLimit;
        public decimal CreditLimit
        {
            get { return creditLimit; }
        }

        public  CreditLine(decimal creditLimit, decimal balance) : base(balance)
        {
            this.creditLimit = creditLimit;
            this.minimumBalance = creditLimit *(-1m);
            this.balance = balance;
            name = "Line Of Credit";
        }

   

        public decimal AmountBorrowed()
        {
            return creditLimit - balance;
        }

        public override void Withdraw(decimal amount)
        {
            balance -= amount;
        }

    }





}
