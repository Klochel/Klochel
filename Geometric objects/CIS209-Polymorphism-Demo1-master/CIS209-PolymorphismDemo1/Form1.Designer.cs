namespace CIS209_PolymorphismDemo1
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
            this.btnBird = new System.Windows.Forms.Button();
            this.btnFish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblContainer = new System.Windows.Forms.Label();
            this.lblLocomotion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBird
            // 
            this.btnBird.Location = new System.Drawing.Point(15, 75);
            this.btnBird.Name = "btnBird";
            this.btnBird.Size = new System.Drawing.Size(75, 23);
            this.btnBird.TabIndex = 0;
            this.btnBird.Text = "Buy a Bird";
            this.btnBird.UseVisualStyleBackColor = true;
            this.btnBird.Click += new System.EventHandler(this.btnBird_Click);
            // 
            // btnFish
            // 
            this.btnFish.Location = new System.Drawing.Point(197, 75);
            this.btnFish.Name = "btnFish";
            this.btnFish.Size = new System.Drawing.Size(75, 23);
            this.btnFish.TabIndex = 1;
            this.btnFish.Text = "Buy a Fish";
            this.btnFish.UseVisualStyleBackColor = true;
            this.btnFish.Click += new System.EventHandler(this.btnFish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Pets R\' Us";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your pet\'s name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(148, 43);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(124, 20);
            this.tbxName.TabIndex = 4;
            // 
            // lblContainer
            // 
            this.lblContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContainer.Location = new System.Drawing.Point(19, 112);
            this.lblContainer.Name = "lblContainer";
            this.lblContainer.Size = new System.Drawing.Size(253, 53);
            this.lblContainer.TabIndex = 5;
            // 
            // lblLocomotion
            // 
            this.lblLocomotion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocomotion.Location = new System.Drawing.Point(19, 177);
            this.lblLocomotion.Name = "lblLocomotion";
            this.lblLocomotion.Size = new System.Drawing.Size(253, 56);
            this.lblLocomotion.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 249);
            this.Controls.Add(this.lblLocomotion);
            this.Controls.Add(this.lblContainer);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFish);
            this.Controls.Add(this.btnBird);
            this.Name = "Form1";
            this.Text = "Pets R\' Us";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBird;
        private System.Windows.Forms.Button btnFish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblContainer;
        private System.Windows.Forms.Label lblLocomotion;
    }
}

