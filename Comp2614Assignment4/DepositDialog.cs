using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankMachine;

namespace Comp2614Assignment4
{
    public partial class DepositOrWithdrawDialog : ModalDialog
    {
        public BankAccountCollection Accounts
        {
            get
            {
                if (selectedCustomer != null)
                {
                    return selectedCustomer.Accounts;
                }
                else
                {
                    return null;
                }

            }
        }

        private BankAccount selectedBankAccount;
        public BankAccount SelectedBankAccount
        {
            get { return selectedBankAccount; }
            set
            {
                if (value != null)
                {
                    selectedBankAccount = value;
                }
            }
        }

        private decimal amount;
        public decimal Amount
        {
            get { return amount; }
        }

        private Customer selectedCustomer;
        public Customer SelectedCustomer
        {
            get { return selectedCustomer; }
            set
            {
                if (value != null)
                {
                    selectedCustomer = value;
                }
            }

        }

        private Transaction transaction;
        public Transaction CurrentTransaction
        {
            get
            {
                return transaction;
            }

            set
            {
                if (value != null)
                {
                    transaction = value;
                }
            }
        }

        private string title;
        public string Title
        {
            set
            {
                if (value != string.Empty && value.Trim().Length > 0)
                {
                    title = value;
                }
            }
        }


        public DepositOrWithdrawDialog()
        {
            InitializeComponent();
        }

        private void DepositOrWithdrawDialog_Load(object sender, EventArgs e)
        {
            this.Text = title;
            populateAccountBox();
            comboBoxAccounts.ValueMember = "NameAndNumberDisplay";
        }

        private void populateAccountBox()
        {
            if (Accounts != null)
            {
                foreach (BankAccount account in Accounts)
                {
                    comboBoxAccounts.Items.Add(account);
                }
            }
            if (comboBoxAccounts.Items.Count > 0)
            {
                comboBoxAccounts.SelectedIndex = 0;
            }
        }

        protected bool validateInput()
        {

            bool accountIsValid;
            if (comboBoxAccounts.SelectedItem == null)
            {
                errorProviderMain.SetError(comboBoxAccounts, "Please select an account");
                accountIsValid = false;
            }
            else
            {

                selectedBankAccount = comboBoxAccounts.SelectedItem as BankAccount;
                
                errorProviderMain.SetError(comboBoxAccounts, string.Empty);
                accountIsValid = true;
            }

            bool amountIsValid;
            if (amountIsNumeric() == false)
            {
                errorProviderMain.SetError(textBoxAmount, "Please enter a positive number");
                textBoxAmount.Focus();
                textBoxAmount.SelectAll();
                amountIsValid = false;
            }
            else
            {
                errorProviderMain.SetError(textBoxAmount, string.Empty);

                amount = getAmountEntered();
                amountIsValid = true;
            }
            return (accountIsValid && amountIsValid);

        }

        protected decimal getAmountEntered()
        {
            decimal amountTest;
            decimal.TryParse(textBoxAmount.Text, out amountTest);
            return amountTest;

        }

        protected bool amountIsNumeric()
        {
            decimal amountTest;
            return decimal.TryParse(textBoxAmount.Text, out amountTest);
        }


        private void processRequest()
        {
            if (validateInput())
            {
                BankAccountCollection involvedAccounts = new BankAccountCollection();
                involvedAccounts.Add(selectedBankAccount);
                transaction.Accounts = involvedAccounts;
                transaction.Amount = Amount;

                try
                {
                    transaction.DoTransaction();
                    selectedCustomer.AddTransaction(transaction);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    errorProviderMain.SetError(textBoxAmount, ex.Message);
                    textBoxAmount.Focus();
                    textBoxAmount.SelectAll();
                }

            }
           
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            processRequest();        
        }

     

    }
}
