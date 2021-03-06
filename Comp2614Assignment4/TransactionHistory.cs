﻿using System;
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
    public partial class TransactionHistory : Form
    {
        // The TransactionHistory is a Singleton form that displays the customer's transactions.
        // The form is not modal and can be left up while interacting with the main form.
        // Two display modes: with and without details. Without details, only the date and
        // transaction type are shown. With details, the accounts and amount involved in the
        // transaction are also displayed.
        private static TransactionHistory instance;
       
        private Customer selectedCustomer;
        public Customer SelectedCustomer
        {
            set
            {
                if (value != null)
                {
                    selectedCustomer = value;
                }
            }
        }


        private TransactionHistory()
        {
            InitializeComponent();
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            UpdateHistory();
        }

        public static TransactionHistory CreateForm()   // create public static method with form type return
        {
            if (instance == null)
            {
                instance = new TransactionHistory();
            }

            return instance;
        }

        public void UpdateHistory()
        {
            textBoxHistory.Clear();
            bool detailedView = checkBoxDetails.Checked;
            textBoxHistory.Text = PrintTransactions(detailedView);
            textBoxHistory.SelectionLength = textBoxHistory.Text.Length;
            textBoxHistory.DeselectAll();
            buttonClose.Select();
        }

        private string PrintTransactions(bool detailedView)
        {
            if (selectedCustomer.Transactions.Count == 0)
            {
                return "<none>";
            }

            StringBuilder display = new StringBuilder(1000);
            TransactionCollection transactions = selectedCustomer.Transactions;
            foreach(Transaction transaction in transactions)
            {
                display.Append(transaction.Timestamp.ToString("yyyy-MM-dd"));
                
                display.AppendFormat("  {0}",transaction.Name);
                if (transaction.Status == Transaction.TransactionStatus.Pending)
                {
                    display.Append(" [Pending]");
                }
                if (detailedView)
                {
                    display.Append("\r\n");
                    AppendDetails(display, transaction);
                }
                display.Append("\r\n");
                display.Append("\r\n");
            }
            return display.ToString();
        }

        private void AppendDetails(StringBuilder display, Transaction transaction)
        {
            BankAccountCollection accounts = transaction.Accounts;
            if (accounts.Count == 1)
            {
                display.AppendFormat("      Account: {0}\r\n", accounts.ElementAt(0).Number);
            }

            else
            {
                display.AppendFormat("      From Account: {0}\r\n", accounts.ElementAt(0).Number);
                display.AppendFormat("      To Account: {0}\r\n", accounts.ElementAt(1).Number);
            }

            display.AppendFormat("      Amount: {0:N2}\r\n", transaction.Amount);
        }


        private void TransactionHistoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null; // explicitly set form instance to null as form closes
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxDetails_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHistory();
        }


    }
}
