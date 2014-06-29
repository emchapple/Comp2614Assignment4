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
    public partial class TransferFundsDialog : DepositOrWithdrawDialog
    {
        private BankAccount toAccount;
        public BankAccount ToAccount
        {
            get
            { return toAccount; }

            set
            {
                if (value != null)
                {
                    toAccount = value;
                }
            }
        }

        private TransferFundsTransaction transaction;


        public TransferFundsDialog()
        {
            InitializeComponent();
        }

        private void TransferFundsDialog_Load(object sender, EventArgs e)
        {
            transaction = CurrentTransaction as TransferFundsTransaction;
            comboBoxToAccounts.ValueMember = "NameAndNumberDisplay";
            if (comboBoxAccounts.Items.Count > 0)
            {
                comboBoxAccounts.SelectedIndex = 0;
            }
            populateComboBoxToAccount();
        }

        private void populateComboBoxToAccount()
        {
            comboBoxToAccounts.Items.Clear();
            BankAccount fromAccount = comboBoxAccounts.SelectedItem as BankAccount;
            if (this.Accounts != null)
            {
                foreach (BankAccount account in this.Accounts)
                {
                    if (account != null && account != fromAccount)
                    {
                        comboBoxToAccounts.Items.Add(account);
                    }
                }
                if (comboBoxToAccounts.Items.Count > 0)
                {
                    comboBoxToAccounts.SelectedIndex = 0;
                }
            }
        }

        private void comboBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateComboBoxToAccount();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
                        
            if (validateInputs())
            {

                SelectedBankAccount = comboBoxAccounts.SelectedItem as BankAccount;
                ToAccount = comboBoxToAccounts.SelectedItem as BankAccount;

                BankAccountCollection involvedAccounts = new BankAccountCollection();
                involvedAccounts.Add(SelectedBankAccount);
                involvedAccounts.Add(ToAccount);
                transaction.Accounts = involvedAccounts;
                transaction.Amount = getAmountEntered();

                try
                {
                    transaction.DoTransaction();
                    SelectedCustomer.AddTransaction(transaction);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    errorProviderMain.SetError(textBoxAmount, ex.Message); 
                }

            }
        }


        private bool validateInputs()
        {
            if (validateInput())
            {
                if (comboBoxToAccounts.SelectedItem != null)
                {
                    return true;

                }
            }
                return false;
            
        }

        private bool validateToAccount()
        {
            if (comboBoxToAccounts.SelectedItem != null)
            {
                errorProviderMain.SetError(comboBoxToAccounts, string.Empty);
                return true;
            }
            else
            {
                errorProviderMain.SetError(comboBoxToAccounts, "Please select an account");
                return false;
            }

        }
    }
}