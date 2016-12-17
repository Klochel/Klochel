namespace checkBoxDemo
{
    partial class SundaeOrderForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbFudge = new System.Windows.Forms.CheckBox();
            this.chbNotFudge = new System.Windows.Forms.CheckBox();
            this.chbNuts = new System.Windows.Forms.CheckBox();
            this.chbCherries = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.recap = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbCherries);
            this.groupBox1.Controls.Add(this.chbNuts);
            this.groupBox1.Controls.Add(this.chbNotFudge);
            this.groupBox1.Controls.Add(this.chbFudge);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Your Toppings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make A Silly Sundae";
            // 
            // chbFudge
            // 
            this.chbFudge.AutoSize = true;
            this.chbFudge.Location = new System.Drawing.Point(7, 20);
            this.chbFudge.Name = "chbFudge";
            this.chbFudge.Size = new System.Drawing.Size(56, 17);
            this.chbFudge.TabIndex = 0;
            this.chbFudge.Text = "Fudge";
            this.chbFudge.UseVisualStyleBackColor = true;
            this.chbFudge.CheckedChanged += new System.EventHandler(this.chbFudge_CheckedChanged);
            // 
            // chbNotFudge
            // 
            this.chbNotFudge.AutoSize = true;
            this.chbNotFudge.Location = new System.Drawing.Point(7, 43);
            this.chbNotFudge.Name = "chbNotFudge";
            this.chbNotFudge.Size = new System.Drawing.Size(76, 17);
            this.chbNotFudge.TabIndex = 0;
            this.chbNotFudge.Text = "Not Fudge";
            this.chbNotFudge.UseVisualStyleBackColor = true;
            // 
            // chbNuts
            // 
            this.chbNuts.AutoSize = true;
            this.chbNuts.Location = new System.Drawing.Point(7, 66);
            this.chbNuts.Name = "chbNuts";
            this.chbNuts.Size = new System.Drawing.Size(48, 17);
            this.chbNuts.TabIndex = 0;
            this.chbNuts.Text = "Nuts";
            this.chbNuts.UseVisualStyleBackColor = true;
            // 
            // chbCherries
            // 
            this.chbCherries.AutoSize = true;
            this.chbCherries.Location = new System.Drawing.Point(7, 89);
            this.chbCherries.Name = "chbCherries";
            this.chbCherries.Size = new System.Drawing.Size(64, 17);
            this.chbCherries.TabIndex = 0;
            this.chbCherries.Text = "Cherries";
            this.chbCherries.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(12, 158);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(94, 46);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(186, 158);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 46);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // recap
            // 
            this.recap.AutoSize = true;
            this.recap.Location = new System.Drawing.Point(12, 211);
            this.recap.Name = "recap";
            this.recap.Size = new System.Drawing.Size(0, 13);
            this.recap.TabIndex = 4;
            // 
            // SundaeOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 287);
            this.Controls.Add(this.recap);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SundaeOrderForm";
            this.Text = "Mail Order Sundae";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbCherries;
        private System.Windows.Forms.CheckBox chbNuts;
        private System.Windows.Forms.CheckBox chbNotFudge;
        private System.Windows.Forms.CheckBox chbFudge;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label recap;
    }
}

