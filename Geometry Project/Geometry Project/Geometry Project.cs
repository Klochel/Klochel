using System;
using System.Windows.Forms;

namespace Geometry_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtnRightTriange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRightTriangle.Checked)
            {
                AddRightTriangle frmTriangle = new AddRightTriangle();
                frmTriangle.ShowDialog();
                rbtnRightTriangle.Checked = false;
            }
        }

        private void rbtnRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRectangle.Checked)
            {
                AddRectangle frmRectangle = new AddRectangle();
                frmRectangle.ShowDialog();
                rbtnRectangle.Checked = false;
            }
        }

        private void rbtnCircle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCircle.Checked)
            {
                AddCircle frmCircle = new AddCircle();
                frmCircle.ShowDialog();
                rbtnCircle.Checked = false;
            }
        }
    }
}

