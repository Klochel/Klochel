namespace Dorm_and_Meal_Plan_Calculator
{
    partial class TotalCharges
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
            this.btnEXIT = new System.Windows.Forms.Button();
            this.tbxTotalCharges = new System.Windows.Forms.TextBox();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEXIT
            // 
            this.btnEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXIT.Location = new System.Drawing.Point(93, 142);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(100, 48);
            this.btnEXIT.TabIndex = 2;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // tbxTotalCharges
            // 
            this.tbxTotalCharges.Location = new System.Drawing.Point(143, 102);
            this.tbxTotalCharges.Name = "tbxTotalCharges";
            this.tbxTotalCharges.Size = new System.Drawing.Size(129, 20);
            this.tbxTotalCharges.TabIndex = 3;
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.AutoSize = true;
            this.lblTotalCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCharges.Location = new System.Drawing.Point(12, 104);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(114, 18);
            this.lblTotalCharges.TabIndex = 4;
            this.lblTotalCharges.Text = "Total Charges";
            // 
            // TotalCharges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTotalCharges);
            this.Controls.Add(this.tbxTotalCharges);
            this.Controls.Add(this.btnEXIT);
            this.Name = "TotalCharges";
            this.Text = "Total Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Label lblTotalCharges;
        public System.Windows.Forms.TextBox tbxTotalCharges;
    }
}