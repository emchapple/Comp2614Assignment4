namespace Comp2614Assignment4
{
    partial class TransferFundsDialog
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
            this.labelToAccount = new System.Windows.Forms.Label();
            this.comboBoxToAccounts = new System.Windows.Forms.ComboBox();
            this.errorProviderMain = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAccounts
            // 
            this.comboBoxAccounts.DisplayMember = "NameAndNumberDisplay";
            this.comboBoxAccounts.Location = new System.Drawing.Point(30, 37);
            this.comboBoxAccounts.Size = new System.Drawing.Size(133, 21);
            this.comboBoxAccounts.TabIndex = 5;
            this.comboBoxAccounts.ValueMember = "NameAndNumberDisplay";
            this.comboBoxAccounts.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccounts_SelectedIndexChanged);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(30, 97);
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 1;
            this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelAccount
            // 
            this.labelAccount.Location = new System.Drawing.Point(27, 20);
            this.labelAccount.Size = new System.Drawing.Size(73, 13);
            this.labelAccount.Text = "From Account";
            // 
            // labelAmount
            // 
            this.labelAmount.Location = new System.Drawing.Point(27, 80);
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 0;
            this.labelAmount.Text = "Amount";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(236, 130);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(314, 130);
            this.buttonCancel.TabIndex = 3;
            // 
            // labelToAccount
            // 
            this.labelToAccount.AutoSize = true;
            this.labelToAccount.Location = new System.Drawing.Point(236, 20);
            this.labelToAccount.Name = "labelToAccount";
            this.labelToAccount.Size = new System.Drawing.Size(63, 13);
            this.labelToAccount.TabIndex = 6;
            this.labelToAccount.Text = "To Account";
            // 
            // comboBoxToAccounts
            // 
            this.comboBoxToAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToAccounts.FormattingEnabled = true;
            this.comboBoxToAccounts.Location = new System.Drawing.Point(236, 36);
            this.comboBoxToAccounts.Name = "comboBoxToAccounts";
            this.comboBoxToAccounts.Size = new System.Drawing.Size(136, 21);
            this.comboBoxToAccounts.TabIndex = 7;
            // 
            // errorProviderMain
            // 
            this.errorProviderMain.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMain.ContainerControl = this;
            // 
            // TransferFundsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 161);
            this.Controls.Add(this.comboBoxToAccounts);
            this.Controls.Add(this.labelToAccount);
            this.Name = "TransferFundsDialog";
            this.Text = "TransferFundsDialog";
            this.Load += new System.EventHandler(this.TransferFundsDialog_Load);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.comboBoxAccounts, 0);
            this.Controls.SetChildIndex(this.textBoxAmount, 0);
            this.Controls.SetChildIndex(this.labelAccount, 0);
            this.Controls.SetChildIndex(this.labelAmount, 0);
            this.Controls.SetChildIndex(this.labelToAccount, 0);
            this.Controls.SetChildIndex(this.comboBoxToAccounts, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelToAccount;
        private System.Windows.Forms.ComboBox comboBoxToAccounts;
        private System.Windows.Forms.ErrorProvider errorProviderMain;
    }
}