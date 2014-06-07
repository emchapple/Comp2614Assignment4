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

        

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
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
                accountLine.Text = accountNameAndNumberDisplay(account);
                accountLine.SubItems.Add(account.Balance.ToString("N2"));
                accountLine.SubItems.Add(accountCreditDisplay(account));
                accountLine.SubItems.Add(account.GetAvailableFunds().ToString("N2"));


                listViewAccountsDisplay.Items.Add(accountLine);
            }
            listViewAccountsDisplay.EndUpdate();

        }

        private string accountNameAndNumberDisplay(BankAccount account)
        {
            return string.Format("{0} {1}", account.Name, account.Number);
        }

        private string accountCreditDisplay(BankAccount account)
        {
            string display = "N/A";            
            CreditLine creditLine = account as CreditLine;
            if (creditLine != null)
            {
                display = creditLine.CreditLimit.ToString("N2");
            }
            return display;

        }


    }
}
