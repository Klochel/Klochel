using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS209_PolymorphismDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBird_Click(object sender, EventArgs e)
        {
            if (tbxName.Text != "")
            {
                // A bird is a type of pet
                Pet bird1 = new Bird(tbxName.Text);
                lblContainer.Text = "Would you like to see a nice " + bird1.Container +
                    " for " + bird1.Name + "?";
                tbxName.Text = "";
                lblLocomotion.Text = bird1.Name + " should be a good " + bird1.locomation() + ".";
            }
            else
                MessageBox.Show("Please choose a name for your pet.", "Pets R' Us",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnFish_Click(object sender, EventArgs e)
        {
            if (tbxName.Text != "")
            {
                // A fish is a type of pet
                Pet fish1 = new Fish(tbxName.Text);
                lblContainer.Text = "Would you like to see a nice " + fish1.Container +
                    " for " + fish1.Name + "?";
                tbxName.Text = "";
                lblLocomotion.Text = fish1.Name + " should be a good " +fish1.locomation() + ".";

            }
            else
                MessageBox.Show("Please choose a name for your pet.", "Pets R' Us",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
