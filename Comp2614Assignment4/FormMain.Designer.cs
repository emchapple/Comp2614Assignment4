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
            this.components = new System.ComponentModel.Container();
            this.listViewAccountsDisplay = new System.Windows.Forms.ListView();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.buttonTransferFunds = new System.Windows.Forms.Button();
            this.buttonTransactionHistory = new System.Windows.Forms.Button();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelInfoMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPadding = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateDisplay = new System.Windows.Forms.Timer(this.components);
            this.timerProcessTransactions = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewAccountsDisplay
            // 
            this.listViewAccountsDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAccountsDisplay.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAccountsDisplay.Location = new System.Drawing.Point(12, 13);
            this.listViewAccountsDisplay.Name = "listViewAccountsDisplay";
            this.listViewAccountsDisplay.Size = new System.Drawing.Size(660, 94);
            this.listViewAccountsDisplay.TabIndex = 0;
            this.listViewAccountsDisplay.UseCompatibleStateImageBehavior = false;
            this.listViewAccountsDisplay.View = System.Windows.Forms.View.Details;
            this.listViewAccountsDisplay.ColumnReordered += new System.Windows.Forms.ColumnReorderedEventHandler(this.listViewAccountsDisplay_ColumnReordered);
            this.listViewAccountsDisplay.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listViewAccountsDisplay_ColumnWidthChanging);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMain.ColumnCount = 5;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMain.Controls.Add(this.buttonDeposit, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonWithdraw, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonTransferFunds, 4, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonTransactionHistory, 4, 2);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(12, 128);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(660, 82);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeposit.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeposit.Location = new System.Drawing.Point(3, 3);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(192, 26);
            this.buttonDeposit.TabIndex = 0;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWithdraw.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdraw.Location = new System.Drawing.Point(234, 3);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(192, 26);
            this.buttonWithdraw.TabIndex = 1;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // buttonTransferFunds
            // 
            this.buttonTransferFunds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTransferFunds.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransferFunds.Location = new System.Drawing.Point(465, 3);
            this.buttonTransferFunds.Name = "buttonTransferFunds";
            this.buttonTransferFunds.Size = new System.Drawing.Size(192, 26);
            this.buttonTransferFunds.TabIndex = 2;
            this.buttonTransferFunds.Text = "Transfer Funds";
            this.buttonTransferFunds.UseVisualStyleBackColor = true;
            this.buttonTransferFunds.Click += new System.EventHandler(this.buttonTransferFunds_Click);
            // 
            // buttonTransactionHistory
            // 
            this.buttonTransactionHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTransactionHistory.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransactionHistory.Location = new System.Drawing.Point(465, 51);
            this.buttonTransactionHistory.Name = "buttonTransactionHistory";
            this.buttonTransactionHistory.Size = new System.Drawing.Size(192, 28);
            this.buttonTransactionHistory.TabIndex = 3;
            this.buttonTransactionHistory.Text = "Transaction History";
            this.buttonTransactionHistory.UseVisualStyleBackColor = true;
            this.buttonTransactionHistory.Click += new System.EventHandler(this.buttonTransactionHistory_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfoMessage,
            this.toolStripStatusLabelPadding,
            this.toolStripStatusLabelDate});
            this.statusStripMain.Location = new System.Drawing.Point(0, 223);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(684, 22);
            this.statusStripMain.SizingGrip = false;
            this.statusStripMain.TabIndex = 3;
            // 
            // toolStripStatusLabelInfoMessage
            // 
            this.toolStripStatusLabelInfoMessage.Name = "toolStripStatusLabelInfoMessage";
            this.toolStripStatusLabelInfoMessage.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabelInfoMessage.Text = "< Info Message>";
            // 
            // toolStripStatusLabelPadding
            // 
            this.toolStripStatusLabelPadding.AutoSize = false;
            this.toolStripStatusLabelPadding.Name = "toolStripStatusLabelPadding";
            this.toolStripStatusLabelPadding.Size = new System.Drawing.Size(350, 17);
            // 
            // toolStripStatusLabelDate
            // 
            this.toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            this.toolStripStatusLabelDate.Size = new System.Drawing.Size(223, 17);
            this.toolStripStatusLabelDate.Spring = true;
            this.toolStripStatusLabelDate.Text = "< Date Display>";
            this.toolStripStatusLabelDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerDateDisplay
            // 
            this.timerDateDisplay.Enabled = true;
            this.timerDateDisplay.Interval = 60000;
            this.timerDateDisplay.Tick += new System.EventHandler(this.timerDateDisplay_Tick);
            // 
            // timerProcessTransactions
            // 
            this.timerProcessTransactions.Enabled = true;
            this.timerProcessTransactions.Interval = 5000;
            this.timerProcessTransactions.Tick += new System.EventHandler(this.timerProcessTransactions_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 245);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.listViewAccountsDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Accounts For: <Customer>";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfoMessage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPadding;
        private System.Windows.Forms.Timer timerDateDisplay;
        private System.Windows.Forms.Timer timerProcessTransactions;
    }
}

