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
            if (comboBoxAccounts.SelectedItem != null && amountIsNumeric())
            {
                return true;
            }
            return false;
        }

        protected decimal getAmountEntered()
        {
            return Convert.ToDecimal(textBoxAmount.Text);
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
                selectedBankAccount = comboBoxAccounts.SelectedItem as BankAccount;
                amount = getAmountEntered();
                this.DialogResult = DialogResult.OK;
           
            }
            else
            {
                MessageBox.Show("Something is wrong with your input.");
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            processRequest();        
        }

     

    }
}
