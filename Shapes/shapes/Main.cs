using System;
using System.Windows.Forms;

namespace shapes
{
    //Kevin 
    public partial class Main : Form
    {
        public Main()
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

                // Dispaly items in details tab
                lbxDetailListBox.Items.Add(frmTriangle.getItem());
                tbxRightTriangle.Text = frmTriangle.getCount();

                // Display items in sort tab
                lbxDetailListBox.Items.Add(frmTriangle.getItem());
            }
        }

        private void rbtnRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRectangle.Checked)
            {
                AddRectangle frmRectangle = new AddRectangle();
                frmRectangle.ShowDialog();
                rbtnRectangle.Checked = false;

                // Dispaly items in details tab
                lbxDetailListBox.Items.Add(frmRectangle.getItem());
                tbxRectangle.Text = frmRectangle.getCount();

                // Display items in sort tab
                lbxDetailListBox.Items.Add(frmRectangle.getItem());
            }
        }

        private void rbtnCircle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCircle.Checked)
            {
                AddCircle frmCircle = new AddCircle();
                frmCircle.ShowDialog();
                rbtnCircle.Checked = false;

                // Dispaly items in details tab
                lbxDetailListBox.Items.Add(frmCircle.getItem());
                tbxCircle.Text = frmCircle.getCount();

                // Display items in sort tab
                lbxDetailListBox.Items.Add(frmCircle.getItem());
            }
        }
    }
}
 
