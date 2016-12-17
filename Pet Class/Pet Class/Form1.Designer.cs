namespace Pet_Class
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
            this.tbxPetName = new System.Windows.Forms.TextBox();
            this.tbxPetType = new System.Windows.Forms.TextBox();
            this.tbxPetAge = new System.Windows.Forms.TextBox();
            this.lblPetName = new System.Windows.Forms.Label();
            this.lblPetType = new System.Windows.Forms.Label();
            this.lblPetAge = new System.Windows.Forms.Label();
            this.btnDisplayPet = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPetName
            // 
            this.tbxPetName.Location = new System.Drawing.Point(225, 31);
            this.tbxPetName.Name = "tbxPetName";
            this.tbxPetName.Size = new System.Drawing.Size(100, 20);
            this.tbxPetName.TabIndex = 0;
            // 
            // tbxPetType
            // 
            this.tbxPetType.Location = new System.Drawing.Point(225, 77);
            this.tbxPetType.Name = "tbxPetType";
            this.tbxPetType.Size = new System.Drawing.Size(100, 20);
            this.tbxPetType.TabIndex = 1;
            // 
            // tbxPetAge
            // 
            this.tbxPetAge.Location = new System.Drawing.Point(225, 120);
            this.tbxPetAge.Name = "tbxPetAge";
            this.tbxPetAge.Size = new System.Drawing.Size(100, 20);
            this.tbxPetAge.TabIndex = 2;
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetName.Location = new System.Drawing.Point(92, 32);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(70, 15);
            this.lblPetName.TabIndex = 3;
            this.lblPetName.Text = "Pet Name";
            // 
            // lblPetType
            // 
            this.lblPetType.AutoSize = true;
            this.lblPetType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetType.Location = new System.Drawing.Point(100, 78);
            this.lblPetType.Name = "lblPetType";
            this.lblPetType.Size = new System.Drawing.Size(62, 15);
            this.lblPetType.TabIndex = 4;
            this.lblPetType.Text = "Pet Type";
            // 
            // lblPetAge
            // 
            this.lblPetAge.AutoSize = true;
            this.lblPetAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetAge.Location = new System.Drawing.Point(106, 121);
            this.lblPetAge.Name = "lblPetAge";
            this.lblPetAge.Size = new System.Drawing.Size(56, 15);
            this.lblPetAge.TabIndex = 5;
            this.lblPetAge.Text = "Pet Age";
            // 
            // btnDisplayPet
            // 
            this.btnDisplayPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayPet.Location = new System.Drawing.Point(230, 159);
            this.btnDisplayPet.Name = "btnDisplayPet";
            this.btnDisplayPet.Size = new System.Drawing.Size(95, 41);
            this.btnDisplayPet.TabIndex = 6;
            this.btnDisplayPet.Text = "Display Pet";
            this.btnDisplayPet.UseVisualStyleBackColor = true;
            this.btnDisplayPet.Click += new System.EventHandler(this.btnDisplayPet_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(119, 159);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 41);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnCLEAR_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 159);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 41);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 281);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplayPet);
            this.Controls.Add(this.lblPetAge);
            this.Controls.Add(this.lblPetType);
            this.Controls.Add(this.lblPetName);
            this.Controls.Add(this.tbxPetAge);
            this.Controls.Add(this.tbxPetType);
            this.Controls.Add(this.tbxPetName);
            this.Name = "Form1";
            this.Text = "Pet Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPetName;
        private System.Windows.Forms.TextBox tbxPetType;
        private System.Windows.Forms.TextBox tbxPetAge;
        private System.Windows.Forms.Label lblPetName;
        private System.Windows.Forms.Label lblPetType;
        private System.Windows.Forms.Label lblPetAge;
        private System.Windows.Forms.Button btnDisplayPet;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

