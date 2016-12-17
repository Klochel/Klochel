using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_Counter
{
    public partial class Form1 : Form
    {
        //Constant Fields
        const decimal banana = 115m;
        const decimal apple = 80m;
        const decimal orange = 90m;
        const decimal pear = 120m;

        //Field variable to hold the total
        //Initialized with 0
        private decimal total = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void pbBanana_Click(object sender, EventArgs e)
        {
            //Add the value of the banana calorie together to the total
            total += banana;
     

           //Display the total, formatted as a numerical value.
           tbxTotal.Text = total.ToString("n");
        }

        private void pbApple_Click(object sender, EventArgs e)
        {
            //Add the value of the banana calorie together to the total
            total += apple;

            //Display the total, formatted as a numerical value.
            tbxTotal.Text = total.ToString("n");
        }

        private void pbOrange_Click(object sender, EventArgs e)
        {
            //Add the value of the banana calorie together to the total
            total += orange;

            //Display the total, formatted as a numerical value.
            tbxTotal.Text = total.ToString("n");
        }

        private void pbPear_Click(object sender, EventArgs e)
        {
            //Add the value of the banana calorie together to the total
            total += pear;

            //Display the total, formatted as a numerical value.
            tbxTotal.Text = total.ToString("n");
        }


        private void btnResest_Click(object sender, EventArgs e)
        {
            total = 0;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
