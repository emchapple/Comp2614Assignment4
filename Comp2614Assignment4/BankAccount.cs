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
        private static int highestAccountNumber;

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
            if (amountToAdd > 0)
            {
                balance += amountToAdd;
            }
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if (withdrawalAmountIsValid(amountToWithdraw))
            {
                balance -= amountToWithdraw;
            
            }
            else
            {
                throw new Exception("Insufficient funds.");
            }
        }

        private bool hasSufficientFunds(decimal amount)
        {
            return balance >= amount;
        }

        private bool withdrawalAmountIsValid(decimal amount)
        {
            return amount > 0 && hasSufficientFunds(amount);
        }

        public void transferTo(BankAccount toAccount, decimal amount)
        {
            if (withdrawalAmountIsValid(amount))
            {
                this.balance -= amount;
                toAccount.balance += amount;
            }
            else
            {
                throw new Exception("Inusfficient funds.");
            }
        }

    }

    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(decimal balance) : base(balance)
        {
            minimumBalance = 0m;
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

        public  CreditLine(decimal creditLimit, decimal balance) : base(balance)
        {
            this.creditLimit = creditLimit;
            this.balance = balance;
            name = "Line Of Credit";
        }

        public override decimal GetAvailableFunds()
        {
            return creditLimit - balance;
        }


    }





}
