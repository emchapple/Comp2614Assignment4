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

        public DepositOrWithdrawDialog()
        {
            InitializeComponent();
        }

        private void DepositOrWithdrawDialog_Load(object sender, EventArgs e)
        {
            populateAccountBox();
        }

        private void populateAccountBox()
        {
           // this.comboBoxAccounts.DataSource = Accounts;
            //comboBoxAccounts.DisplayMember = "Utils.accountCreditDisplay()";
            if (Accounts != null)
            {
                foreach (BankAccount account in Accounts)
                {

                    comboBoxAccounts.Items.Add(Utils.accountNameAndNumberDisplay(account));
                    // comboBoxAccounts.Items.
                }
            }
        }

    }
}
