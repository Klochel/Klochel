using System;
using System.Windows.Forms;

namespace Dorm_and_Meal_Plan_Calculator
{
    public partial class frmTotalCharges : Form
    {
       

        public frmTotalCharges()
        {
            InitializeComponent();
        }

        public object lblTotalCharges { get; internal set; }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
