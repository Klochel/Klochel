namespace Geometry_Project
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbCreate = new System.Windows.Forms.TabPage();
            this.rbtnCircle = new System.Windows.Forms.RadioButton();
            this.rbtnRightTriangle = new System.Windows.Forms.RadioButton();
            this.rbtnRectangle = new System.Windows.Forms.RadioButton();
            this.tbSummary = new System.Windows.Forms.TabPage();
            this.lbxListBoxOfShapes = new System.Windows.Forms.ListBox();
            this.tbDetail = new System.Windows.Forms.TabPage();
            this.tbxCountCircles = new System.Windows.Forms.TextBox();
            this.tbxCountRightTriangles = new System.Windows.Forms.TextBox();
            this.tbxCountRectangles = new System.Windows.Forms.TextBox();
            this.lblCountCircles = new System.Windows.Forms.Label();
            this.lblCountRightTriangles = new System.Windows.Forms.Label();
            this.lblCountRectangles = new System.Windows.Forms.Label();
            this.tbSort = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tbCreate.SuspendLayout();
            this.tbSummary.SuspendLayout();
            this.tbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbCreate);
            this.tabControl1.Controls.Add(this.tbSummary);
            this.tabControl1.Controls.Add(this.tbDetail);
            this.tabControl1.Controls.Add(this.tbSort);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(285, 264);
            this.tabControl1.TabIndex = 0;
            // 
            // tbCreate
            // 
            this.tbCreate.Controls.Add(this.rbtnCircle);
            this.tbCreate.Controls.Add(this.rbtnRightTriangle);
            this.tbCreate.Controls.Add(this.rbtnRectangle);
            this.tbCreate.Location = new System.Drawing.Point(4, 22);
            this.tbCreate.Name = "tbCreate";
            this.tbCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tbCreate.Size = new System.Drawing.Size(277, 238);
            this.tbCreate.TabIndex = 0;
            this.tbCreate.Text = "Create";
            this.tbCreate.UseVisualStyleBackColor = true;
            // 
            // rbtnCircle
            // 
            this.rbtnCircle.AutoSize = true;
            this.rbtnCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCircle.Location = new System.Drawing.Point(79, 126);
            this.rbtnCircle.Name = "rbtnCircle";
            this.rbtnCircle.Size = new System.Drawing.Size(82, 28);
            this.rbtnCircle.TabIndex = 2;
            this.rbtnCircle.TabStop = true;
            this.rbtnCircle.Text = "Circle";
            this.rbtnCircle.UseVisualStyleBackColor = true;
            this.rbtnCircle.CheckedChanged += new System.EventHandler(this.rbtnCircle_CheckedChanged);
            // 
            // rbtnRightTriangle
            // 
            this.rbtnRightTriangle.AutoSize = true;
            this.rbtnRightTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRightTriangle.Location = new System.Drawing.Point(79, 85);
            this.rbtnRightTriangle.Name = "rbtnRightTriangle";
            this.rbtnRightTriangle.Size = new System.Drawing.Size(153, 28);
            this.rbtnRightTriangle.TabIndex = 1;
            this.rbtnRightTriangle.TabStop = true;
            this.rbtnRightTriangle.Text = "RightTriangle";
            this.rbtnRightTriangle.UseVisualStyleBackColor = true;
            this.rbtnRightTriangle.CheckedChanged += new System.EventHandler(this.rbtnRightTriangle_CheckedChanged);
            // 
            // rbtnRectangle
            // 
            this.rbtnRectangle.AutoSize = true;
            this.rbtnRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRectangle.Location = new System.Drawing.Point(79, 45);
            this.rbtnRectangle.Name = "rbtnRectangle";
            this.rbtnRectangle.Size = new System.Drawing.Size(122, 28);
            this.rbtnRectangle.TabIndex = 0;
            this.rbtnRectangle.TabStop = true;
            this.rbtnRectangle.Text = "Rectangle";
            this.rbtnRectangle.UseVisualStyleBackColor = true;
            this.rbtnRectangle.CheckedChanged += new System.EventHandler(this.rbtnRectangle_CheckedChanged);
            // 
            // tbSummary
            // 
            this.tbSummary.Controls.Add(this.lbxListBoxOfShapes);
            this.tbSummary.Location = new System.Drawing.Point(4, 22);
            this.tbSummary.Name = "tbSummary";
            this.tbSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tbSummary.Size = new System.Drawing.Size(277, 238);
            this.tbSummary.TabIndex = 1;
            this.tbSummary.Text = "Summary";
            this.tbSummary.UseVisualStyleBackColor = true;
            // 
            // lbxListBoxOfShapes
            // 
            this.lbxListBoxOfShapes.FormattingEnabled = true;
            this.lbxListBoxOfShapes.Items.AddRange(new object[] {
            "lbxListBoxOfShapes",
            "Rectangle.Count",
            "RightTriangle.Count",
            "Circle.Count",
            "Rectangle.Item",
            "RightTriangle.Item",
            "Circle.Item"});
            this.lbxListBoxOfShapes.Location = new System.Drawing.Point(56, 49);
            this.lbxListBoxOfShapes.Name = "lbxListBoxOfShapes";
            this.lbxListBoxOfShapes.Size = new System.Drawing.Size(120, 121);
            this.lbxListBoxOfShapes.TabIndex = 0;
            // 
            // tbDetail
            // 
            this.tbDetail.Controls.Add(this.tbxCountCircles);
            this.tbDetail.Controls.Add(this.tbxCountRightTriangles);
            this.tbDetail.Controls.Add(this.tbxCountRectangles);
            this.tbDetail.Controls.Add(this.lblCountCircles);
            this.tbDetail.Controls.Add(this.lblCountRightTriangles);
            this.tbDetail.Controls.Add(this.lblCountRectangles);
            this.tbDetail.Location = new System.Drawing.Point(4, 22);
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tbDetail.Size = new System.Drawing.Size(277, 238);
            this.tbDetail.TabIndex = 2;
            this.tbDetail.Text = "Detail";
            this.tbDetail.UseVisualStyleBackColor = true;
            // 
            // tbxCountCircles
            // 
            this.tbxCountCircles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCountCircles.Location = new System.Drawing.Point(208, 96);
            this.tbxCountCircles.Name = "tbxCountCircles";
            this.tbxCountCircles.Size = new System.Drawing.Size(53, 20);
            this.tbxCountCircles.TabIndex = 5;
            this.tbxCountCircles.Text = "0";
            this.tbxCountCircles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxCountRightTriangles
            // 
            this.tbxCountRightTriangles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCountRightTriangles.Location = new System.Drawing.Point(208, 65);
            this.tbxCountRightTriangles.Name = "tbxCountRightTriangles";
            this.tbxCountRightTriangles.Size = new System.Drawing.Size(53, 20);
            this.tbxCountRightTriangles.TabIndex = 4;
            this.tbxCountRightTriangles.Text = "0";
            this.tbxCountRightTriangles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxCountRectangles
            // 
            this.tbxCountRectangles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCountRectangles.Location = new System.Drawing.Point(208, 30);
            this.tbxCountRectangles.Name = "tbxCountRectangles";
            this.tbxCountRectangles.Size = new System.Drawing.Size(53, 20);
            this.tbxCountRectangles.TabIndex = 3;
            this.tbxCountRectangles.Text = "0";
            this.tbxCountRectangles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxCountRectangles.TextChanged += new System.EventHandler(this.tbxCountRectangles_TextChanged);
            // 
            // lblCountCircles
            // 
            this.lblCountCircles.AutoSize = true;
            this.lblCountCircles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountCircles.Location = new System.Drawing.Point(61, 97);
            this.lblCountCircles.Name = "lblCountCircles";
            this.lblCountCircles.Size = new System.Drawing.Size(99, 16);
            this.lblCountCircles.TabIndex = 2;
            this.lblCountCircles.Text = "Count Circles";
            // 
            // lblCountRightTriangles
            // 
            this.lblCountRightTriangles.AutoSize = true;
            this.lblCountRightTriangles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountRightTriangles.Location = new System.Drawing.Point(20, 66);
            this.lblCountRightTriangles.Name = "lblCountRightTriangles";
            this.lblCountRightTriangles.Size = new System.Drawing.Size(157, 16);
            this.lblCountRightTriangles.TabIndex = 1;
            this.lblCountRightTriangles.Text = "Count Right Triangles";
            // 
            // lblCountRectangles
            // 
            this.lblCountRectangles.AutoSize = true;
            this.lblCountRectangles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountRectangles.Location = new System.Drawing.Point(30, 31);
            this.lblCountRectangles.Name = "lblCountRectangles";
            this.lblCountRectangles.Size = new System.Drawing.Size(130, 16);
            this.lblCountRectangles.TabIndex = 0;
            this.lblCountRectangles.Text = "Count Rectangles";
            // 
            // tbSort
            // 
            this.tbSort.Location = new System.Drawing.Point(4, 22);
            this.tbSort.Name = "tbSort";
            this.tbSort.Padding = new System.Windows.Forms.Padding(3);
            this.tbSort.Size = new System.Drawing.Size(277, 238);
            this.tbSort.TabIndex = 3;
            this.tbSort.Text = "Sort";
            this.tbSort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Geometry Project";
            this.tabControl1.ResumeLayout(false);
            this.tbCreate.ResumeLayout(false);
            this.tbCreate.PerformLayout();
            this.tbSummary.ResumeLayout(false);
            this.tbDetail.ResumeLayout(false);
            this.tbDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbCreate;
        private System.Windows.Forms.TabPage tbSummary;
        private System.Windows.Forms.TabPage tbDetail;
        private System.Windows.Forms.TabPage tbSort;
        private System.Windows.Forms.RadioButton rbtnCircle;
        private System.Windows.Forms.RadioButton rbtnRightTriangle;
        private System.Windows.Forms.RadioButton rbtnRectangle;
        private System.Windows.Forms.ListBox lbxListBoxOfShapes;
        private System.Windows.Forms.Label lblCountCircles;
        private System.Windows.Forms.Label lblCountRightTriangles;
        private System.Windows.Forms.Label lblCountRectangles;
        private System.Windows.Forms.TextBox tbxCountCircles;
        private System.Windows.Forms.TextBox tbxCountRightTriangles;
        private System.Windows.Forms.TextBox tbxCountRectangles;
    }
}

