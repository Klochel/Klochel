namespace Hospital_Charges
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
            this.btnCLEAR = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.tbxNumberOfDays = new System.Windows.Forms.TextBox();
            this.tbxMedication = new System.Windows.Forms.TextBox();
            this.tbxSurgical = new System.Windows.Forms.TextBox();
            this.tbxLabFee = new System.Windows.Forms.TextBox();
            this.tbxPhysicalRehabilitation = new System.Windows.Forms.TextBox();
            this.tbxTotalCharges = new System.Windows.Forms.TextBox();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.lblMedication = new System.Windows.Forms.Label();
            this.lblSurgical = new System.Windows.Forms.Label();
            this.lblLabFee = new System.Windows.Forms.Label();
            this.lblPhysicalRehabilitation = new System.Windows.Forms.Label();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.btnCALCULATE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCLEAR
            // 
            this.btnCLEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLEAR.Location = new System.Drawing.Point(2, 222);
            this.btnCLEAR.Name = "btnCLEAR";
            this.btnCLEAR.Size = new System.Drawing.Size(68, 36);
            this.btnCLEAR.TabIndex = 0;
            this.btnCLEAR.Text = "CLEAR";
            this.btnCLEAR.UseVisualStyleBackColor = true;
            this.btnCLEAR.Click += new System.EventHandler(this.btnCLEAR_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXIT.Location = new System.Drawing.Point(80, 222);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(68, 36);
            this.btnEXIT.TabIndex = 1;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // tbxNumberOfDays
            // 
            this.tbxNumberOfDays.Location = new System.Drawing.Point(172, 21);
            this.tbxNumberOfDays.Name = "tbxNumberOfDays";
            this.tbxNumberOfDays.Size = new System.Drawing.Size(100, 20);
            this.tbxNumberOfDays.TabIndex = 2;
            // 
            // tbxMedication
            // 
            this.tbxMedication.Location = new System.Drawing.Point(172, 48);
            this.tbxMedication.Name = "tbxMedication";
            this.tbxMedication.Size = new System.Drawing.Size(100, 20);
            this.tbxMedication.TabIndex = 3;
            // 
            // tbxSurgical
            // 
            this.tbxSurgical.Location = new System.Drawing.Point(172, 74);
            this.tbxSurgical.Name = "tbxSurgical";
            this.tbxSurgical.Size = new System.Drawing.Size(100, 20);
            this.tbxSurgical.TabIndex = 4;
            // 
            // tbxLabFee
            // 
            this.tbxLabFee.Location = new System.Drawing.Point(172, 100);
            this.tbxLabFee.Name = "tbxLabFee";
            this.tbxLabFee.Size = new System.Drawing.Size(100, 20);
            this.tbxLabFee.TabIndex = 5;
            // 
            // tbxPhysicalRehabilitation
            // 
            this.tbxPhysicalRehabilitation.Location = new System.Drawing.Point(172, 126);
            this.tbxPhysicalRehabilitation.Name = "tbxPhysicalRehabilitation";
            this.tbxPhysicalRehabilitation.Size = new System.Drawing.Size(100, 20);
            this.tbxPhysicalRehabilitation.TabIndex = 6;
            // 
            // tbxTotalCharges
            // 
            this.tbxTotalCharges.Location = new System.Drawing.Point(172, 194);
            this.tbxTotalCharges.Name = "tbxTotalCharges";
            this.tbxTotalCharges.Size = new System.Drawing.Size(100, 20);
            this.tbxTotalCharges.TabIndex = 7;
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDays.Location = new System.Drawing.Point(49, 24);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(99, 13);
            this.lblNumberOfDays.TabIndex = 8;
            this.lblNumberOfDays.Text = "Number Of Days";
            // 
            // lblMedication
            // 
            this.lblMedication.AutoSize = true;
            this.lblMedication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedication.Location = new System.Drawing.Point(76, 51);
            this.lblMedication.Name = "lblMedication";
            this.lblMedication.Size = new System.Drawing.Size(69, 13);
            this.lblMedication.TabIndex = 9;
            this.lblMedication.Text = "Medication";
            // 
            // lblSurgical
            // 
            this.lblSurgical.AutoSize = true;
            this.lblSurgical.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurgical.Location = new System.Drawing.Point(92, 77);
            this.lblSurgical.Name = "lblSurgical";
            this.lblSurgical.Size = new System.Drawing.Size(53, 13);
            this.lblSurgical.TabIndex = 10;
            this.lblSurgical.Text = "Surgical";
            // 
            // lblLabFee
            // 
            this.lblLabFee.AutoSize = true;
            this.lblLabFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabFee.Location = new System.Drawing.Point(92, 103);
            this.lblLabFee.Name = "lblLabFee";
            this.lblLabFee.Size = new System.Drawing.Size(53, 13);
            this.lblLabFee.TabIndex = 11;
            this.lblLabFee.Text = "Lab Fee";
            // 
            // lblPhysicalRehabilitation
            // 
            this.lblPhysicalRehabilitation.AutoSize = true;
            this.lblPhysicalRehabilitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhysicalRehabilitation.Location = new System.Drawing.Point(12, 129);
            this.lblPhysicalRehabilitation.Name = "lblPhysicalRehabilitation";
            this.lblPhysicalRehabilitation.Size = new System.Drawing.Size(136, 13);
            this.lblPhysicalRehabilitation.TabIndex = 12;
            this.lblPhysicalRehabilitation.Text = "Physical Rehabilitation";
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.AutoSize = true;
            this.lblTotalCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCharges.Location = new System.Drawing.Point(62, 197);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(86, 13);
            this.lblTotalCharges.TabIndex = 13;
            this.lblTotalCharges.Text = "Total Charges";
            // 
            // btnCALCULATE
            // 
            this.btnCALCULATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCALCULATE.Location = new System.Drawing.Point(172, 152);
            this.btnCALCULATE.Name = "btnCALCULATE";
            this.btnCALCULATE.Size = new System.Drawing.Size(100, 36);
            this.btnCALCULATE.TabIndex = 14;
            this.btnCALCULATE.Text = "CALCULATE";
            this.btnCALCULATE.UseVisualStyleBackColor = true;
            this.btnCALCULATE.Click += new System.EventHandler(this.btnCALCULATE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCALCULATE);
            this.Controls.Add(this.lblTotalCharges);
            this.Controls.Add(this.lblPhysicalRehabilitation);
            this.Controls.Add(this.lblLabFee);
            this.Controls.Add(this.lblSurgical);
            this.Controls.Add(this.lblMedication);
            this.Controls.Add(this.lblNumberOfDays);
            this.Controls.Add(this.tbxTotalCharges);
            this.Controls.Add(this.tbxPhysicalRehabilitation);
            this.Controls.Add(this.tbxLabFee);
            this.Controls.Add(this.tbxSurgical);
            this.Controls.Add(this.tbxMedication);
            this.Controls.Add(this.tbxNumberOfDays);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnCLEAR);
            this.Name = "Form1";
            this.Text = "Hospital Charges  Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCLEAR;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.TextBox tbxNumberOfDays;
        private System.Windows.Forms.TextBox tbxMedication;
        private System.Windows.Forms.TextBox tbxSurgical;
        private System.Windows.Forms.TextBox tbxLabFee;
        private System.Windows.Forms.TextBox tbxPhysicalRehabilitation;
        private System.Windows.Forms.TextBox tbxTotalCharges;
        private System.Windows.Forms.Label lblNumberOfDays;
        private System.Windows.Forms.Label lblMedication;
        private System.Windows.Forms.Label lblSurgical;
        private System.Windows.Forms.Label lblLabFee;
        private System.Windows.Forms.Label lblPhysicalRehabilitation;
        private System.Windows.Forms.Label lblTotalCharges;
        private System.Windows.Forms.Button btnCALCULATE;
    }
}

