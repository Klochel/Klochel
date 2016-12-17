using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {


                decimal grossPay = decimal.Parse(tbHourlyPayRate.Text) *
                   decimal.Parse(tbHoursWorked.Text);
                MessageBox.Show("Gross Pay = " + grossPay.ToString("c"), "Pay Rate Calculator");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            tbHourlyPayRate.Text = "";
            tbHoursWorked.Text = "";

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
