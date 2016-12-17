namespace Geometry_Project
{
    partial class AddRectangle
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbxLength = new System.Windows.Forms.TextBox();
            this.tbxWidth = new System.Windows.Forms.TextBox();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.tbxPerimeter = new System.Windows.Forms.TextBox();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.btnCLEAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(100, 37);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(46, 13);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(106, 63);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(40, 13);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(106, 116);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(41, 16);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(66, 143);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(75, 16);
            this.lblPerimeter.TabIndex = 3;
            this.lblPerimeter.Text = "Perimeter";
//            this.lblPerimeter.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(201, 86);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(117, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // tbxLength
            // 
            this.tbxLength.Location = new System.Drawing.Point(201, 34);
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.Size = new System.Drawing.Size(116, 20);
            this.tbxLength.TabIndex = 5;
            // 
            // tbxWidth
            // 
            this.tbxWidth.Location = new System.Drawing.Point(201, 60);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(116, 20);
            this.tbxWidth.TabIndex = 6;
            // 
            // tbxArea
            // 
            this.tbxArea.Location = new System.Drawing.Point(201, 115);
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.Size = new System.Drawing.Size(116, 20);
            this.tbxArea.TabIndex = 7;
            // 
            // tbxPerimeter
            // 
            this.tbxPerimeter.Location = new System.Drawing.Point(201, 142);
            this.tbxPerimeter.Name = "tbxPerimeter";
            this.tbxPerimeter.Size = new System.Drawing.Size(116, 20);
            this.tbxPerimeter.TabIndex = 8;
            // 
            // btnEXIT
            // 
            this.btnEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXIT.Location = new System.Drawing.Point(201, 179);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(87, 34);
            this.btnEXIT.TabIndex = 9;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = true;
//            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // btnCLEAR
            // 
            this.btnCLEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLEAR.Location = new System.Drawing.Point(59, 179);
            this.btnCLEAR.Name = "btnCLEAR";
            this.btnCLEAR.Size = new System.Drawing.Size(87, 34);
            this.btnCLEAR.TabIndex = 10;
            this.btnCLEAR.Text = "CLEAR";
            this.btnCLEAR.UseVisualStyleBackColor = true;
            // 
            // AddRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 225);
            this.Controls.Add(this.btnCLEAR);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.tbxPerimeter);
            this.Controls.Add(this.tbxArea);
            this.Controls.Add(this.tbxWidth);
            this.Controls.Add(this.tbxLength);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddRectangle";
            this.Text = "AddRectangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbxLength;
        private System.Windows.Forms.TextBox tbxWidth;
        private System.Windows.Forms.TextBox tbxArea;
        private System.Windows.Forms.TextBox tbxPerimeter;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Button btnCLEAR;
    }
}