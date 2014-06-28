using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMachine
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

        public abstract decimal GetAvailableFunds();



        public void Deposit(decimal amountToAdd)
        {

            balance += amountToAdd;

        }

        public void Withdraw(decimal amountToWithdraw)
        {
            balance -= amountToWithdraw;
        }

        public void TransferTo(BankAccount toAccount, decimal amount)
        {
            Withdraw(amount);
            toAccount.Deposit(amount);
        }
    }


    public class SavingsAccount : BankAccount
    {

        public SavingsAccount(decimal balance)
            : base(balance)
        {
            name = "Savings Account";
        }

        public override decimal GetAvailableFunds()
        {
            return balance;

        }


    }

    public class CreditLine : BankAccount
    {
        private decimal creditLimit;
        public decimal CreditLimit
        {
            get { return creditLimit; }
        }


        public CreditLine(decimal creditLimit, decimal balance)
            : base(balance)
        {
            this.creditLimit = creditLimit;
            this.balance = balance;
            name = "Line Of Credit";
        }

        public override decimal GetAvailableFunds()
        {

            return balance + creditLimit;

        }



    }






}