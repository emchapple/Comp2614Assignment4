﻿namespace Comp2614Assignment4
{
    partial class DepositOrWithdrawDialog
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
            this.comboBoxAccounts = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelAccount = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxAccounts
            // 
            this.comboBoxAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccounts.FormattingEnabled = true;
            this.comboBoxAccounts.Location = new System.Drawing.Point(83, 25);
            this.comboBoxAccounts.Name = "comboBoxAccounts";
            this.comboBoxAccounts.Size = new System.Drawing.Size(214, 21);
            this.comboBoxAccounts.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 3;
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(27, 32);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(50, 13);
            this.labelAccount.TabIndex = 4;
            this.labelAccount.Text = "Account:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(27, 59);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(46, 13);
            this.labelAmount.TabIndex = 5;
            this.labelAmount.Text = "Amount:";
            // 
            // DepositOrWithdrawDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 140);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxAccounts);
            this.Name = "DepositOrWithdrawDialog";
            this.Text = "DepositDialog";
            this.Load += new System.EventHandler(this.DepositOrWithdrawDialog_Load);
            this.Controls.SetChildIndex(this.comboBoxAccounts, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.labelAccount, 0);
            this.Controls.SetChildIndex(this.labelAmount, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAccounts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Label labelAmount;
    }
}