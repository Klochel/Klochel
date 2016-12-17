namespace ListBoxDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(36, 13);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(212, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Select a city and I will give you a time zone.";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Denver",
            "Mordor",
            "Minneapolis",
            "New York",
            "San Francisco",
            "Vin Diesel\'s House"});
            this.listBox1.Location = new System.Drawing.Point(84, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 82);
            this.listBox1.TabIndex = 1;
            // 
            // lb2
            // 
            this.lb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb2.Location = new System.Drawing.Point(112, 190);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(139, 23);
            this.lb2.TabIndex = 2;
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb2.Click += new System.EventHandler(this.lb2_Click);
            // 
            // bt1
            // 
            this.bt1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt1.BackgroundImage")));
            this.bt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt1.Location = new System.Drawing.Point(39, 220);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(102, 29);
            this.bt1.TabIndex = 3;
            this.bt1.Text = "OK";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt2.BackgroundImage")));
            this.bt2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt2.Location = new System.Drawing.Point(152, 220);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(99, 29);
            this.bt2.TabIndex = 4;
            this.bt2.Text = "EXIT";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(45, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time Zone:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lb1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Xander Cage, or Nick Cage?";
            this.Text = "Time Zone XTREME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Label label1;
    }
}

