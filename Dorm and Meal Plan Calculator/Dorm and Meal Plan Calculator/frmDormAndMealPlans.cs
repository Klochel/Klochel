using System;
using System.Windows.Forms;

namespace Dorm_and_Meal_Plan_Calculator
{
    // enum values to be used for calculations
    enum Dorm
    {
        allenHall = 1500, pikeHall = 1600, farthingHall = 1800,
        universitySuites = 2500, sevenMeals = 600,
        fourteenMeals = 1200, unlimitedMeals = 1700,
    }

    public partial class frmDormAndMealPlans : Form
    {
        // Global variables
        double total;
        double value1 = 0, value2 = 0;

        public object totalCharges { get; private set; }

        public frmDormAndMealPlans()
        {
            InitializeComponent();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCALCULATE_Click(object sender, EventArgs e)
        {
            // Create an instance of frmTotalCharges
            TotalCharges tbxTotalCharges = new TotalCharges();

            // Check what dormitory is selected
            if (rbtAllenHall.Checked)
            {
                value1 += (double)Dorm.allenHall;
                total += value1;
            }
            else if (rbtPikeHall.Checked)
            {
                value1 += (double)Dorm.pikeHall;
                total += value1;
            }
            else if (rbtFarthingHall.Checked)
            {
                value1 += (double)Dorm.farthingHall;
                total += value1;
            }
            else if (rbtUniversitySuites.Checked)
            {
                value1 += (double)Dorm.universitySuites;
                total += value1;
            }

            // Check what meal plan is selected
            if (rbtSevenMeals.Checked)
            {
                value2 += (double)Dorm.sevenMeals;
                total = value1 + value2;
            }
            else if (rbtFourteenMeals.Checked)
            {
                value2 += (double)Dorm.fourteenMeals;
                total = value1 + value2;
            }
            else if (rbtUnlimitedMeals.Checked)
            {
                value2 += (double)Dorm.unlimitedMeals;
                total = value1 + value2;
            }

            // Set label in frmTotalCharges to total's value
            TotalCharges frm2 = new TotalCharges();
            frm2.tbxTotalCharges.Text = total.ToString("c");


            // Display frmTotalCharges
            frm2.ShowDialog();

            // Set all values to 0 after form finishes executing
            total = 0;
            value1 = 0;
            value2 = 0;
        
        }
    }
}
