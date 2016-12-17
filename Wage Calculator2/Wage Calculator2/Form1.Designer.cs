namespace Wage_Calculator2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbLabel1 = new System.Windows.Forms.Label();
            this.tbLabel2 = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.Label();
            this.tbxHoursWorked = new System.Windows.Forms.TextBox();
            this.tbxHourlyPayRate = new System.Windows.Forms.TextBox();
            this.tbxCalculatedGrossPay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(190, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbLabel1
            // 
            this.tbLabel1.AutoSize = true;
            this.tbLabel1.Location = new System.Drawing.Point(13, 36);
            this.tbLabel1.Name = "tbLabel1";
            this.tbLabel1.Size = new System.Drawing.Size(76, 13);
            this.tbLabel1.TabIndex = 3;
            this.tbLabel1.Text = "Hours Worked";
            // 
            // tbLabel2
            // 
            this.tbLabel2.AutoSize = true;
            this.tbLabel2.Location = new System.Drawing.Point(17, 78);
            this.tbLabel2.Name = "tbLabel2";
            this.tbLabel2.Size = new System.Drawing.Size(84, 13);
            this.tbLabel2.TabIndex = 4;
            this.tbLabel2.Text = "Hourly Pay Rate";
            // 
            // tbxTotal
            // 
            this.tbxTotal.AutoSize = true;
            this.tbxTotal.Location = new System.Drawing.Point(16, 122);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(108, 13);
            this.tbxTotal.TabIndex = 5;
            this.tbxTotal.Text = "Calculated Gross Pay";
            // 
            // tbxHoursWorked
            // 
            this.tbxHoursWorked.Location = new System.Drawing.Point(165, 33);
            this.tbxHoursWorked.Name = "tbxHoursWorked";
            this.tbxHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.tbxHoursWorked.TabIndex = 6;
            this.tbxHoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxHourlyPayRate
            // 
            this.tbxHourlyPayRate.Location = new System.Drawing.Point(165, 78);
            this.tbxHourlyPayRate.Name = "tbxHourlyPayRate";
            this.tbxHourlyPayRate.Size = new System.Drawing.Size(100, 20);
            this.tbxHourlyPayRate.TabIndex = 7;
            this.tbxHourlyPayRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxCalculatedGrossPay
            // 
            this.tbxCalculatedGrossPay.Enabled = false;
            this.tbxCalculatedGrossPay.Location = new System.Drawing.Point(165, 122);
            this.tbxCalculatedGrossPay.Name = "tbxCalculatedGrossPay";
            this.tbxCalculatedGrossPay.Size = new System.Drawing.Size(100, 20);
            this.tbxCalculatedGrossPay.TabIndex = 8;
            this.tbxCalculatedGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbxCalculatedGrossPay);
            this.Controls.Add(this.tbxHourlyPayRate);
            this.Controls.Add(this.tbxHoursWorked);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.tbLabel2);
            this.Controls.Add(this.tbLabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Wage Calculator2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label tbLabel1;
        private System.Windows.Forms.Label tbLabel2;
        private System.Windows.Forms.Label tbxTotal;
        private System.Windows.Forms.TextBox tbxHoursWorked;
        private System.Windows.Forms.TextBox tbxHourlyPayRate;
        private System.Windows.Forms.TextBox tbxCalculatedGrossPay;
    }
}

