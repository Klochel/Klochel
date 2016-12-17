using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkBoxDemo
{
    public partial class SundaeOrderForm : Form
    {
        public SundaeOrderForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chbFudge_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string recap = "Your toppings:\n";
            if (chbFudge.Checked)
                recap += "Fudge\n";

            if (chbNotFudge.Checked)
                recap += "Not Fudge\n";

            if (chbNuts.Checked)
                recap += "Nuts\n";

            if (chbCherries.Checked)
                recap += "Cherries\n";

            lblRecap.Text = recap;
            chbFudge.Checked = false;
            chbNotFudge.Checked = false;
            chbNuts.Checked = false;
            chbCherries.Checked = false;
        }
    }
}
