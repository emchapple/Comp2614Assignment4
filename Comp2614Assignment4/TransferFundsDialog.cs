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
    public partial class TransferFundsDialog : DepositOrWithdrawDialog
    {
        public TransferFundsDialog()
        {
            InitializeComponent();
        }

        private void TransferFundsDialog_Load(object sender, EventArgs e)
        {
            comboBoxToAccounts.ValueMember = "NameAndNumberDisplay";
            comboBoxAccounts.SelectedIndex = 0;
            populateComboBoxToAccount();
        }

        private void populateComboBoxToAccount()
        {
            comboBoxToAccounts.Items.Clear();
            BankAccount fromAccount = comboBoxAccounts.SelectedItem as BankAccount;
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

        private void comboBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateComboBoxToAccount();
        }
    }
}