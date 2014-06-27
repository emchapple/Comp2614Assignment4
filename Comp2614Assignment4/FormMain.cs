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
            toolStripStatusLabelInfoMessage.Text = string.Empty;
            setTitleDisplay();
            setupListView();
            populateListView();
            refreshStatusStrip();

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
            listViewAccountsDisplay.Columns.Add("Account Name", 220);
            listViewAccountsDisplay.Columns.Add("Balance", 140, HorizontalAlignment.Right);
            listViewAccountsDisplay.Columns.Add("Credit Limit", 140, HorizontalAlignment.Right);
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

                string accountBalanceString = getBalanceDisplayString(account);
                Color accountBalanceColor = getBalanceColor(account);
                accountLine.SubItems.Add(accountBalanceString, accountBalanceColor, SystemColors.Window, listViewAccountsDisplay.Font);

                accountLine.SubItems.Add(Utils.accountCreditDisplay(account));
                accountLine.SubItems.Add(account.Balance.ToString("N2"));
                listViewAccountsDisplay.Items.Add(accountLine);
            }
            listViewAccountsDisplay.EndUpdate();

        }
            

        private string getBalanceDisplayString(BankAccount account)
        {
            string displayString = string.Empty;
            CreditLine creditLine = account as CreditLine;
            if (creditLine != null)
                {
                    if (creditLine.AmountBorrowed() > 0m)
                    {
                        return string.Format("({0})", (creditLine.AmountBorrowed()).ToString("N2"));
                    }
                    else
                    {
                        decimal valuetodisplay = account.Balance - creditLine.CreditLimit;
                        return valuetodisplay.ToString("N2");
                    }
                   

                }
                
              return account.Balance.ToString("N2");
             
        }

        private Color getBalanceColor(BankAccount account)
        {
            if (account is CreditLine)
            {
                CreditLine creditLine = account as CreditLine;
                if (creditLine.AmountBorrowed() > 0m)
                {
                    return Color.Red;

                }
            }
            return Color.Black;

        }



        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelInfoMessage.Text = "Enter a Deposit";
            DepositOrWithdrawDialog depositDlg = new DepositOrWithdrawDialog();
            Transaction transaction = new DepositTransaction();
            doFullTransaction(transaction, depositDlg);
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelInfoMessage.Text = "Enter a Withdrawal";
            DepositOrWithdrawDialog withdrawalDlg = new DepositOrWithdrawDialog();
            Transaction transaction = new WithdrawalTransaction();
            doFullTransaction(transaction, withdrawalDlg);
        }

        private void buttonTransferFunds_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelInfoMessage.Text = "Enter a Transfer";
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
                RefreshScreen();
            }
            toolStripStatusLabelInfoMessage.Text = string.Empty;

        }

        private void RefreshScreen()
        {
            updateHistoryDisplay();
            populateListView();
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
                history.SelectedCustomer = selectedCustomer;
                history.UpdateHistory();
            }
        }
    

        private void listViewAccountsDisplay_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
        //    labelDebug.Text = e.Cancel.ToString();
            e.NewWidth = listViewAccountsDisplay.Columns[e.ColumnIndex].Width;
        }

        private void listViewAccountsDisplay_ColumnReordered(object sender, ColumnReorderedEventArgs e)
        {
            e.Cancel = true;
        }

        private void refreshStatusStrip()
        {
            toolStripStatusLabelDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy  h:mm tt");

        }

        private void timerDateDisplay_Tick(object sender, EventArgs e)
        {
            refreshStatusStrip();
        }

        private void timerProcessTransactions_Tick(object sender, EventArgs e)
        {
            bool changed = selectedCustomer.ProcessTransactions();
            if (changed)
            {
                RefreshScreen();
            }
        }
        


       
    }
}
