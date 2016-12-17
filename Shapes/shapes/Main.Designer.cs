namespace shapes
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbxCreate = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCircle = new System.Windows.Forms.RadioButton();
            this.rbtnRectangle = new System.Windows.Forms.RadioButton();
            this.rbtnRightTriangle = new System.Windows.Forms.RadioButton();
            this.tbxSummary = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCircle = new System.Windows.Forms.Label();
            this.lblRectangle = new System.Windows.Forms.Label();
            this.lblRightTriangle = new System.Windows.Forms.Label();
            this.tbxCircle = new System.Windows.Forms.TextBox();
            this.tbxRectangle = new System.Windows.Forms.TextBox();
            this.tbxRightTriangle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDetail = new System.Windows.Forms.TabPage();
            this.lbxDetailListBox = new System.Windows.Forms.ListBox();
            this.tbxSort = new System.Windows.Forms.TabPage();
            this.SortListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnSortByPerimeter = new System.Windows.Forms.RadioButton();
            this.rbtnSortByArea = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tbxCreate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbxSummary.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbxDetail.SuspendLayout();
            this.tbxSort.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbxCreate);
            this.tabControl1.Controls.Add(this.tbxSummary);
            this.tabControl1.Controls.Add(this.tbxDetail);
            this.tabControl1.Controls.Add(this.tbxSort);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 264);
            this.tabControl1.TabIndex = 0;
            // 
            // tbxCreate
            // 
            this.tbxCreate.Controls.Add(this.groupBox1);
            this.tbxCreate.Location = new System.Drawing.Point(4, 22);
            this.tbxCreate.Name = "tbxCreate";
            this.tbxCreate.Size = new System.Drawing.Size(331, 238);
            this.tbxCreate.TabIndex = 0;
            this.tbxCreate.Text = "Create";
            this.tbxCreate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCircle);
            this.groupBox1.Controls.Add(this.rbtnRectangle);
            this.groupBox1.Controls.Add(this.rbtnRightTriangle);
            this.groupBox1.Location = new System.Drawing.Point(62, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a Shape to Create";
            // 
            // rbtnCircle
            // 
            this.rbtnCircle.AutoSize = true;
            this.rbtnCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCircle.Location = new System.Drawing.Point(7, 66);
            this.rbtnCircle.Name = "rbtnCircle";
            this.rbtnCircle.Size = new System.Drawing.Size(66, 20);
            this.rbtnCircle.TabIndex = 3;
            this.rbtnCircle.TabStop = true;
            this.rbtnCircle.Text = "&Circle";
            this.rbtnCircle.UseVisualStyleBackColor = true;
            this.rbtnCircle.CheckedChanged += new System.EventHandler(this.rbtnCircle_CheckedChanged);
            // 
            // rbtnRectangle
            // 
            this.rbtnRectangle.AutoSize = true;
            this.rbtnRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRectangle.Location = new System.Drawing.Point(6, 43);
            this.rbtnRectangle.Name = "rbtnRectangle";
            this.rbtnRectangle.Size = new System.Drawing.Size(97, 20);
            this.rbtnRectangle.TabIndex = 2;
            this.rbtnRectangle.TabStop = true;
            this.rbtnRectangle.Text = "&Rectangle";
            this.rbtnRectangle.UseVisualStyleBackColor = true;
            this.rbtnRectangle.CheckedChanged += new System.EventHandler(this.rbtnRectangle_CheckedChanged);
            // 
            // rbtnRightTriangle
            // 
            this.rbtnRightTriangle.AutoSize = true;
            this.rbtnRightTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRightTriangle.Location = new System.Drawing.Point(7, 20);
            this.rbtnRightTriangle.Name = "rbtnRightTriangle";
            this.rbtnRightTriangle.Size = new System.Drawing.Size(124, 20);
            this.rbtnRightTriangle.TabIndex = 0;
            this.rbtnRightTriangle.TabStop = true;
            this.rbtnRightTriangle.Text = "Right &Triangle";
            this.rbtnRightTriangle.UseVisualStyleBackColor = true;
            this.rbtnRightTriangle.CheckedChanged += new System.EventHandler(this.rbtnRightTriange_CheckedChanged);
            // 
            // tbxSummary
            // 
            this.tbxSummary.Controls.Add(this.groupBox2);
            this.tbxSummary.Controls.Add(this.label1);
            this.tbxSummary.Location = new System.Drawing.Point(4, 22);
            this.tbxSummary.Name = "tbxSummary";
            this.tbxSummary.Size = new System.Drawing.Size(331, 238);
            this.tbxSummary.TabIndex = 1;
            this.tbxSummary.Text = "Summary";
            this.tbxSummary.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCircle);
            this.groupBox2.Controls.Add(this.lblRectangle);
            this.groupBox2.Controls.Add(this.lblRightTriangle);
            this.groupBox2.Controls.Add(this.tbxCircle);
            this.groupBox2.Controls.Add(this.tbxRectangle);
            this.groupBox2.Controls.Add(this.tbxRightTriangle);
            this.groupBox2.Location = new System.Drawing.Point(53, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 136);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventory Summary";
            // 
            // lblCircle
            // 
            this.lblCircle.AutoSize = true;
            this.lblCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircle.Location = new System.Drawing.Point(58, 76);
            this.lblCircle.Name = "lblCircle";
            this.lblCircle.Size = new System.Drawing.Size(48, 16);
            this.lblCircle.TabIndex = 12;
            this.lblCircle.Text = "Circle";
            // 
            // lblRectangle
            // 
            this.lblRectangle.AutoSize = true;
            this.lblRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRectangle.Location = new System.Drawing.Point(41, 46);
            this.lblRectangle.Name = "lblRectangle";
            this.lblRectangle.Size = new System.Drawing.Size(79, 16);
            this.lblRectangle.TabIndex = 11;
            this.lblRectangle.Text = "Rectangle";
            // 
            // lblRightTriangle
            // 
            this.lblRightTriangle.AutoSize = true;
            this.lblRightTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightTriangle.Location = new System.Drawing.Point(32, 16);
            this.lblRightTriangle.Name = "lblRightTriangle";
            this.lblRightTriangle.Size = new System.Drawing.Size(106, 16);
            this.lblRightTriangle.TabIndex = 10;
            this.lblRightTriangle.Text = "Right Triangle";
            // 
            // tbxCircle
            // 
            this.tbxCircle.Location = new System.Drawing.Point(154, 75);
            this.tbxCircle.Name = "tbxCircle";
            this.tbxCircle.Size = new System.Drawing.Size(44, 20);
            this.tbxCircle.TabIndex = 9;
            this.tbxCircle.Text = "0";
            this.tbxCircle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxRectangle
            // 
            this.tbxRectangle.Location = new System.Drawing.Point(154, 45);
            this.tbxRectangle.Name = "tbxRectangle";
            this.tbxRectangle.Size = new System.Drawing.Size(44, 20);
            this.tbxRectangle.TabIndex = 8;
            this.tbxRectangle.Text = "0";
            this.tbxRectangle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxRightTriangle
            // 
            this.tbxRightTriangle.Location = new System.Drawing.Point(154, 15);
            this.tbxRightTriangle.Name = "tbxRightTriangle";
            this.tbxRightTriangle.Size = new System.Drawing.Size(44, 20);
            this.tbxRightTriangle.TabIndex = 7;
            this.tbxRightTriangle.Text = "0";
            this.tbxRightTriangle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 10);
            this.label1.TabIndex = 0;
            this.label1.Text = "Right Triangles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxDetail
            // 
            this.tbxDetail.Controls.Add(this.lbxDetailListBox);
            this.tbxDetail.Location = new System.Drawing.Point(4, 22);
            this.tbxDetail.Name = "tbxDetail";
            this.tbxDetail.Size = new System.Drawing.Size(331, 238);
            this.tbxDetail.TabIndex = 2;
            this.tbxDetail.Text = "Detail";
            this.tbxDetail.UseVisualStyleBackColor = true;
            // 
            // lbxDetailListBox
            // 
            this.lbxDetailListBox.FormattingEnabled = true;
            this.lbxDetailListBox.Location = new System.Drawing.Point(16, 18);
            this.lbxDetailListBox.Name = "lbxDetailListBox";
            this.lbxDetailListBox.Size = new System.Drawing.Size(302, 199);
            this.lbxDetailListBox.TabIndex = 0;
            // 
            // tbxSort
            // 
            this.tbxSort.Controls.Add(this.SortListBox);
            this.tbxSort.Controls.Add(this.panel1);
            this.tbxSort.Location = new System.Drawing.Point(4, 22);
            this.tbxSort.Name = "tbxSort";
            this.tbxSort.Size = new System.Drawing.Size(331, 238);
            this.tbxSort.TabIndex = 3;
            this.tbxSort.Text = "Sort";
            this.tbxSort.UseVisualStyleBackColor = true;
            // 
            // SortListBox
            // 
            this.SortListBox.FormattingEnabled = true;
            this.SortListBox.Location = new System.Drawing.Point(164, 13);
            this.SortListBox.Name = "SortListBox";
            this.SortListBox.Size = new System.Drawing.Size(158, 199);
            this.SortListBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbtnSortByPerimeter);
            this.panel1.Controls.Add(this.rbtnSortByArea);
            this.panel1.Location = new System.Drawing.Point(9, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 55);
            this.panel1.TabIndex = 0;
            // 
            // rbtnSortByPerimeter
            // 
            this.rbtnSortByPerimeter.AutoSize = true;
            this.rbtnSortByPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSortByPerimeter.Location = new System.Drawing.Point(4, 27);
            this.rbtnSortByPerimeter.Name = "rbtnSortByPerimeter";
            this.rbtnSortByPerimeter.Size = new System.Drawing.Size(136, 19);
            this.rbtnSortByPerimeter.TabIndex = 1;
            this.rbtnSortByPerimeter.TabStop = true;
            this.rbtnSortByPerimeter.Text = "Sort by Perimeter";
            this.rbtnSortByPerimeter.UseVisualStyleBackColor = true;
            // 
            // rbtnSortByArea
            // 
            this.rbtnSortByArea.AutoSize = true;
            this.rbtnSortByArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSortByArea.Location = new System.Drawing.Point(4, 4);
            this.rbtnSortByArea.Name = "rbtnSortByArea";
            this.rbtnSortByArea.Size = new System.Drawing.Size(102, 19);
            this.rbtnSortByArea.TabIndex = 0;
            this.rbtnSortByArea.TabStop = true;
            this.rbtnSortByArea.Text = "Sort by Area";
            this.rbtnSortByArea.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 264);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Geometry Project";
            this.tabControl1.ResumeLayout(false);
            this.tbxCreate.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbxSummary.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbxDetail.ResumeLayout(false);
            this.tbxSort.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbxCreate;
        private System.Windows.Forms.TabPage tbxSummary;
        private System.Windows.Forms.TabPage tbxDetail;
        private System.Windows.Forms.TabPage tbxSort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCircle;
        private System.Windows.Forms.RadioButton rbtnRectangle;
        private System.Windows.Forms.RadioButton rbtnRightTriangle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnSortByPerimeter;
        private System.Windows.Forms.RadioButton rbtnSortByArea;
        private System.Windows.Forms.ListBox lbxDetailListBox;
        private System.Windows.Forms.ListBox SortListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCircle;
        private System.Windows.Forms.Label lblRectangle;
        private System.Windows.Forms.Label lblRightTriangle;
        private System.Windows.Forms.TextBox tbxCircle;
        private System.Windows.Forms.TextBox tbxRectangle;
        private System.Windows.Forms.TextBox tbxRightTriangle;
        private System.Windows.Forms.Label label1;
    }
}

