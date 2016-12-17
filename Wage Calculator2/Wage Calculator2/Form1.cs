using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wage_Calculator2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Calculate gross pay when numerical numbers are entered
                decimal grossPay = decimal.Parse(tbxHourlyPayRate.Text) *
                    decimal.Parse(tbxHoursWorked.Text);
                tbxCalculatedGrossPay.Text = grossPay.ToString("c");
            }
            catch
            {
                //Display an error message if wrong text is entered in the text fields
                MessageBox.Show("Error: Data must be entered in munerical form");
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            tbxHoursWorked.Text = "";
            tbxHourlyPayRate.Text = "";
            tbxCalculatedGrossPay.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        { 
            Close();

        }
}
}
