namespace Ice_Cream_Shop
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
            this.lbxFlavors = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblChoices = new System.Windows.Forms.Label();
            this.lblChoice = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxFlavors
            // 
            this.lbxFlavors.AccessibleDescription = "";
            this.lbxFlavors.FormattingEnabled = true;
            this.lbxFlavors.Location = new System.Drawing.Point(43, 45);
            this.lbxFlavors.Name = "lbxFlavors";
            this.lbxFlavors.Size = new System.Drawing.Size(188, 82);
            this.lbxFlavors.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.AutoEllipsis = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(185, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblChoices
            // 
            this.lblChoices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoices.Location = new System.Drawing.Point(43, 9);
            this.lblChoices.Name = "lblChoices";
            this.lblChoices.Size = new System.Drawing.Size(188, 33);
            this.lblChoices.TabIndex = 3;
            this.lblChoices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChoice
            // 
            this.lblChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChoice.Location = new System.Drawing.Point(43, 132);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(188, 46);
            this.lblChoice.TabIndex = 4;
            this.lblChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.AutoEllipsis = true;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 36);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 257);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblChoice);
            this.Controls.Add(this.lblChoices);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbxFlavors);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "U-Serve Ice Cream Parlor 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxFlavors;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblChoices;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.Button btnClear;
    }
}

