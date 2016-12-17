namespace shapes
{
    partial class AddCircle
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
            this.tbxCircumference = new System.Windows.Forms.TextBox();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.tbxRadius = new System.Windows.Forms.TextBox();
            this.tbxDiameter = new System.Windows.Forms.TextBox();
            this.btnAddCircle = new System.Windows.Forms.Button();
            this.lblSide1 = new System.Windows.Forms.Label();
            this.lblSide2 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCircumference = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxCircumference
            // 
            this.tbxCircumference.Location = new System.Drawing.Point(172, 132);
            this.tbxCircumference.Name = "tbxCircumference";
            this.tbxCircumference.Size = new System.Drawing.Size(100, 20);
            this.tbxCircumference.TabIndex = 1;
            // 
            // tbxArea
            // 
            this.tbxArea.Location = new System.Drawing.Point(172, 106);
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.Size = new System.Drawing.Size(100, 20);
            this.tbxArea.TabIndex = 2;
            // 
            // tbxRadius
            // 
            this.tbxRadius.Location = new System.Drawing.Point(172, 25);
            this.tbxRadius.Name = "tbxRadius";
            this.tbxRadius.Size = new System.Drawing.Size(100, 20);
            this.tbxRadius.TabIndex = 3;
            // 
            // tbxDiameter
            // 
            this.tbxDiameter.Location = new System.Drawing.Point(172, 51);
            this.tbxDiameter.Name = "tbxDiameter";
            this.tbxDiameter.Size = new System.Drawing.Size(100, 20);
            this.tbxDiameter.TabIndex = 4;
            // 
            // btnAddCircle
            // 
            this.btnAddCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCircle.Location = new System.Drawing.Point(172, 77);
            this.btnAddCircle.Name = "btnAddCircle";
            this.btnAddCircle.Size = new System.Drawing.Size(100, 23);
            this.btnAddCircle.TabIndex = 5;
            this.btnAddCircle.Text = "Add Circle";
            this.btnAddCircle.UseVisualStyleBackColor = true;
            this.btnAddCircle.Click += new System.EventHandler(this.btnAddCircle_Click);
            // 
            // lblSide1
            // 
            this.lblSide1.AutoSize = true;
            this.lblSide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSide1.Location = new System.Drawing.Point(79, 26);
            this.lblSide1.Name = "lblSide1";
            this.lblSide1.Size = new System.Drawing.Size(46, 16);
            this.lblSide1.TabIndex = 6;
            this.lblSide1.Text = "Side 1";
            // 
            // lblSide2
            // 
            this.lblSide2.AutoSize = true;
            this.lblSide2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSide2.Location = new System.Drawing.Point(77, 52);
            this.lblSide2.Name = "lblSide2";
            this.lblSide2.Size = new System.Drawing.Size(43, 16);
            this.lblSide2.TabIndex = 7;
            this.lblSide2.Text = "Side2";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(79, 106);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(41, 16);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area";
            // 
            // lblCircumference
            // 
            this.lblCircumference.AutoSize = true;
            this.lblCircumference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircumference.Location = new System.Drawing.Point(43, 133);
            this.lblCircumference.Name = "lblCircumference";
            this.lblCircumference.Size = new System.Drawing.Size(107, 16);
            this.lblCircumference.TabIndex = 9;
            this.lblCircumference.Text = "Circumference";
            // 
            // AddCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblCircumference);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblSide2);
            this.Controls.Add(this.lblSide1);
            this.Controls.Add(this.btnAddCircle);
            this.Controls.Add(this.tbxDiameter);
            this.Controls.Add(this.tbxRadius);
            this.Controls.Add(this.tbxArea);
            this.Controls.Add(this.tbxCircumference);
            this.Name = "AddCircle";
            this.Text = "Add Circle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxCircumference;
        private System.Windows.Forms.TextBox tbxArea;
        private System.Windows.Forms.TextBox tbxRadius;
        private System.Windows.Forms.TextBox tbxDiameter;
        private System.Windows.Forms.Button btnAddCircle;
        private System.Windows.Forms.Label lblSide1;
        private System.Windows.Forms.Label lblSide2;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCircumference;
    }
}