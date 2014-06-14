namespace Comp2614Assignment4
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewAccountsDisplay = new System.Windows.Forms.ListView();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.buttonTransferFunds = new System.Windows.Forms.Button();
            this.buttonTransactionHistory = new System.Windows.Forms.Button();
            this.labelDebug = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewAccountsDisplay
            // 
            this.listViewAccountsDisplay.Location = new System.Drawing.Point(58, 46);
            this.listViewAccountsDisplay.Name = "listViewAccountsDisplay";
            this.listViewAccountsDisplay.Size = new System.Drawing.Size(727, 162);
            this.listViewAccountsDisplay.TabIndex = 0;
            this.listViewAccountsDisplay.UseCompatibleStateImageBehavior = false;
            this.listViewAccountsDisplay.View = System.Windows.Forms.View.Details;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 5;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.Controls.Add(this.buttonDeposit, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonWithdraw, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonTransferFunds, 4, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonTransactionHistory, 4, 2);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(58, 227);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(727, 111);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeposit.Location = new System.Drawing.Point(3, 3);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(175, 38);
            this.buttonDeposit.TabIndex = 0;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdraw.Location = new System.Drawing.Point(274, 3);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(175, 38);
            this.buttonWithdraw.TabIndex = 1;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // buttonTransferFunds
            // 
            this.buttonTransferFunds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTransferFunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransferFunds.Location = new System.Drawing.Point(545, 3);
            this.buttonTransferFunds.Name = "buttonTransferFunds";
            this.buttonTransferFunds.Size = new System.Drawing.Size(179, 38);
            this.buttonTransferFunds.TabIndex = 2;
            this.buttonTransferFunds.Text = "Transfer Funds";
            this.buttonTransferFunds.UseVisualStyleBackColor = true;
            this.buttonTransferFunds.Click += new System.EventHandler(this.buttonTransferFunds_Click);
            // 
            // buttonTransactionHistory
            // 
            this.buttonTransactionHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTransactionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransactionHistory.Location = new System.Drawing.Point(545, 69);
            this.buttonTransactionHistory.Name = "buttonTransactionHistory";
            this.buttonTransactionHistory.Size = new System.Drawing.Size(179, 39);
            this.buttonTransactionHistory.TabIndex = 3;
            this.buttonTransactionHistory.Text = "Transaction History";
            this.buttonTransactionHistory.UseVisualStyleBackColor = true;
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Location = new System.Drawing.Point(283, 13);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(35, 13);
            this.labelDebug.TabIndex = 2;
            this.labelDebug.Text = "label1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 358);
            this.Controls.Add(this.labelDebug);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.listViewAccountsDisplay);
            this.Name = "FormMain";
            this.Text = "Accounts For: <Customer>";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAccountsDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button buttonTransferFunds;
        private System.Windows.Forms.Button buttonTransactionHistory;
        private System.Windows.Forms.Label labelDebug;
    }
}

