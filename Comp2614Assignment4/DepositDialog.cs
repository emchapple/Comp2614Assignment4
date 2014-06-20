using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp2614Assignment4
{
    public partial class DepositOrWithdrawDialog : ModalDialog
    {
        public List<BankAccount> Accounts { get; set; }
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



        public DepositOrWithdrawDialog()
        {
            InitializeComponent();
        }

        private void DepositOrWithdrawDialog_Load(object sender, EventArgs e)
        {
            this.Text = "Transaction";
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
        }

        private bool validateInput()
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
          //  return Convert.ToDecimal(textBoxAmount.Text);
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

                this.DialogResult = DialogResult.OK;
            }
           
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            processRequest();        
        }

     

    }
}
