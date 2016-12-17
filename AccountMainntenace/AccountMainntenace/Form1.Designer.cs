namespace AccountMaintenance
{
    partial class Form1
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
            this.btnAddAcount = new System.Windows.Forms.Button();
            this.btnVerifyAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnClearAllAccounts = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAccountList = new System.Windows.Forms.Label();
            this.AccountListBox = new System.Windows.Forms.ListBox();
            this.tbxAccountLookup = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddAcount
            // 
            this.btnAddAcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAcount.Location = new System.Drawing.Point(238, 59);
            this.btnAddAcount.Name = "btnAddAcount";
            this.btnAddAcount.Size = new System.Drawing.Size(94, 44);
            this.btnAddAcount.TabIndex = 0;
            this.btnAddAcount.Text = "Add Account";
            this.btnAddAcount.UseVisualStyleBackColor = true;
            this.btnAddAcount.Click += new System.EventHandler(this.btnAddAcount_Click);
            // 
            // btnVerifyAccount
            // 
            this.btnVerifyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyAccount.Location = new System.Drawing.Point(238, 109);
            this.btnVerifyAccount.Name = "btnVerifyAccount";
            this.btnVerifyAccount.Size = new System.Drawing.Size(94, 44);
            this.btnVerifyAccount.TabIndex = 1;
            this.btnVerifyAccount.Text = "Verify Account";
            this.btnVerifyAccount.UseVisualStyleBackColor = true;
            this.btnVerifyAccount.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(238, 159);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(94, 44);
            this.btnDeleteAccount.TabIndex = 2;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearAllAccounts
            // 
            this.btnClearAllAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAllAccounts.Location = new System.Drawing.Point(238, 209);
            this.btnClearAllAccounts.Name = "btnClearAllAccounts";
            this.btnClearAllAccounts.Size = new System.Drawing.Size(94, 44);
            this.btnClearAllAccounts.TabIndex = 3;
            this.btnClearAllAccounts.Text = "Clear All Accounts";
            this.btnClearAllAccounts.UseVisualStyleBackColor = true;
            this.btnClearAllAccounts.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(238, 259);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 44);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAccountList
            // 
            this.lblAccountList.AutoSize = true;
            this.lblAccountList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountList.Location = new System.Drawing.Point(18, 23);
            this.lblAccountList.Name = "lblAccountList";
            this.lblAccountList.Size = new System.Drawing.Size(109, 20);
            this.lblAccountList.TabIndex = 5;
            this.lblAccountList.Text = "Account List";
            // 
            // AccountListBox
            // 
            this.AccountListBox.FormattingEnabled = true;
            this.AccountListBox.Location = new System.Drawing.Point(22, 46);
            this.AccountListBox.Name = "AccountListBox";
            this.AccountListBox.Size = new System.Drawing.Size(142, 290);
            this.AccountListBox.TabIndex = 6;
            // 
            // tbxAccountLookup
            // 
            this.tbxAccountLookup.Location = new System.Drawing.Point(232, 25);
            this.tbxAccountLookup.Name = "tbxAccountLookup";
            this.tbxAccountLookup.Size = new System.Drawing.Size(100, 20);
            this.tbxAccountLookup.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 362);
            this.Controls.Add(this.tbxAccountLookup);
            this.Controls.Add(this.AccountListBox);
            this.Controls.Add(this.lblAccountList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearAllAccounts);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnVerifyAccount);
            this.Controls.Add(this.btnAddAcount);
            this.Name = "Form1";
            this.Text = "Account Maintenace System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAcount;
        private System.Windows.Forms.Button btnVerifyAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnClearAllAccounts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAccountList;
        private System.Windows.Forms.ListBox AccountListBox;
        private System.Windows.Forms.TextBox tbxAccountLookup;
    }
}

