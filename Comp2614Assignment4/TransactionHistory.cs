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
    public partial class TransactionHistory : Form
    {
        private static TransactionHistory instance;
        private string history;
        public string History
        {
            set { history = value; }
        }

        private TransactionHistory()
        {
            InitializeComponent();
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            textBoxHistory.Text = history;
        }

        public static TransactionHistory CreateForm()   // create public static method with form type return
        {
            if (instance == null)
            {
                instance = new TransactionHistory();
            }

            return instance;
        }

        private void TransactionHistoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null; // explicitly set form instance to null as form closes
        }


    }
}
