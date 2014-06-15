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
    public partial class FormMain : Form
    {
        private Customer selectedCustomer {get;set;}

        public FormMain(Customer customer)
      
        {
            this.selectedCustomer = customer;
            InitializeComponent();
        }
        public FormMain()
        {

            InitializeComponent();
        }
        

        private void buttonTransferFunds_Click(object sender, EventArgs e)
        {
            TransferFundsDialog transferDlg = new TransferFundsDialog();
            transferDlg.Accounts = selectedCustomer.Accounts;
            transferDlg.ShowDialog();
            DialogResult result = transferDlg.DialogResult;
            if (result == DialogResult.OK)
            {
                TransferFundsTransaction transaction = new TransferFundsTransaction();
                transaction.Account = transferDlg.SelectedBankAccount;
                transaction.ToAccount = transferDlg.ToAccount;
                transaction.Amount = transferDlg.Amount;
                try
                {

                    transaction.Process();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("That won't work.");
                }
                populateListView();

            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
          
            labelDebug.Text = string.Empty;
            setTitleDisplay();
            setupListView();
            populateListView();
        }

        private void setTitleDisplay()
        {
            this.Text = string.Format("Accounts for: {0} {1}", selectedCustomer.FirstName, selectedCustomer.LastName);
        }


        private void setupListView()
        {
            listViewAccountsDisplay.View = View.Details;
            listViewAccountsDisplay.FullRowSelect = true;

            // column headers
            listViewAccountsDisplay.Columns.Add("Account Name", 150);
            listViewAccountsDisplay.Columns.Add("Balance", 120, HorizontalAlignment.Right);
            listViewAccountsDisplay.Columns.Add("Credit Limit", 120, HorizontalAlignment.Right);
            listViewAccountsDisplay.Columns.Add("Available Funds", -2, HorizontalAlignment.Right);

            listViewAccountsDisplay.AllowColumnReorder = true;
            listViewAccountsDisplay.GridLines = false;

            listViewAccountsDisplay.Sorting = SortOrder.None;

          
        }

        private void populateListView()
        {

            listViewAccountsDisplay.Items.Clear();
            listViewAccountsDisplay.BeginUpdate();

            foreach (BankAccount account in selectedCustomer.Accounts)
            {
                ListViewItem accountLine = new ListViewItem();
                accountLine.Text = Utils.accountNameAndNumberDisplay(account);
                accountLine.SubItems.Add(account.Balance.ToString("N2"));
                accountLine.SubItems.Add(Utils.accountCreditDisplay(account));
                accountLine.SubItems.Add(account.GetAvailableFunds().ToString("N2"));


                listViewAccountsDisplay.Items.Add(accountLine);
            }
            listViewAccountsDisplay.EndUpdate();

        }

    

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            Transaction transaction = new DepositTransaction();
            doFullTransaction(transaction);
          
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            Transaction transaction = new WithdrawalTransaction();
            doFullTransaction(transaction);
        }

        private void doFullTransaction(Transaction transaction)
        {
            DepositOrWithdrawDialog depositDlg = new DepositOrWithdrawDialog();
                depositDlg.Accounts = selectedCustomer.Accounts;
                depositDlg.ShowDialog();
                DialogResult result = depositDlg.DialogResult;
                if (result == DialogResult.OK)
                {
                    transaction.Account = depositDlg.SelectedBankAccount;
                    transaction.Amount = depositDlg.Amount;
                    try
                    {
                        transaction.DoTransaction();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("That won't work.");
                    }
                    populateListView();

                }
            }
    
        


       
    }
}
