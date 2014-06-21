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
    public partial class              FormMain : Form
    {
        private Customer selectedCustomer {get;set;}
        private TransactionHistory history;
        public FormMain(Customer customer)
      
        {
            this.selectedCustomer = customer;
            InitializeComponent();
        }
        public FormMain()
        {
            InitializeComponent();
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
            listViewAccountsDisplay.Columns.Add("Account Name", 180);
            listViewAccountsDisplay.Columns.Add("Balance", 150, HorizontalAlignment.Right);
            listViewAccountsDisplay.Columns.Add("Credit Limit", 150, HorizontalAlignment.Right);
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
                accountLine.UseItemStyleForSubItems = false;
                Color color = listViewAccountsDisplay.ForeColor;
                accountLine.Text = Utils.accountNameAndNumberDisplay(account);
                if (account is CreditLine)
                {
                    string displayString = string.Empty;
                    CreditLine creditLine = account as CreditLine;
                    if (creditLine.AmountBorrowed() > 0m)
                    {
                        color = Color.Red;
                        displayString = string.Format("({0})", (creditLine.AmountBorrowed()).ToString("N2"));
                    }
                    else
                    {
                        displayString = creditLine.Balance.ToString("N2");
                    }
                    accountLine.SubItems.Add(displayString, color, SystemColors.Window, listViewAccountsDisplay.Font);

                }
                else
                {

                    accountLine.SubItems.Add(account.Balance.ToString("N2"), color, SystemColors.Window, listViewAccountsDisplay.Font);
                }
                accountLine.SubItems.Add(Utils.accountCreditDisplay(account));
                accountLine.SubItems.Add(account.GetAvailableFunds().ToString("N2"));
                listViewAccountsDisplay.Items.Add(accountLine);
            }
            listViewAccountsDisplay.EndUpdate();

        }
            
        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            DepositOrWithdrawDialog depositDlg = new DepositOrWithdrawDialog();
            Transaction transaction = new DepositTransaction();
            doFullTransaction(transaction, depositDlg);
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            DepositOrWithdrawDialog withdrawalDlg = new DepositOrWithdrawDialog();
            Transaction transaction = new WithdrawalTransaction();
            doFullTransaction(transaction, withdrawalDlg);
        }

        private void buttonTransferFunds_Click(object sender, EventArgs e)
        {
            DepositOrWithdrawDialog transferDlg = new TransferFundsDialog();
            Transaction transaction = new TransferFundsTransaction();
            doFullTransaction(transaction, transferDlg);
        }

        private void doFullTransaction(Transaction transaction, DepositOrWithdrawDialog dlg)
        {
            dlg.SelectedCustomer = selectedCustomer;
            dlg.CurrentTransaction = transaction;
            dlg.ShowDialog();
            DialogResult result = dlg.DialogResult;
            if (result == DialogResult.OK)
            {
                updateHistoryDisplay();
                populateListView();
            }
        }


        private void buttonTransactionHistory_Click(object sender, EventArgs e)
        {
            history = TransactionHistory.CreateForm();
            updateHistoryDisplay();
            history.Show();
        }

        private void updateHistoryDisplay()
        {
            if (history != null)
            {
                history.History = selectedCustomer.PrintTransactions();
                history.UpdateHistory();
            }
        }
    

        private void listViewAccountsDisplay_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            labelDebug.Text = e.Cancel.ToString();
            e.NewWidth = listViewAccountsDisplay.Columns[e.ColumnIndex].Width;
        }

        private void listViewAccountsDisplay_ColumnReordered(object sender, ColumnReorderedEventArgs e)
        {
            e.Cancel = true;
        }

     
        


       
    }
}
