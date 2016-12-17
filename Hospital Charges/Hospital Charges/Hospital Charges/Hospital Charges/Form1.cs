using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Charges
{
    public partial class Form1 : Form
    {
        // Declare Variables
        int numberOfDays;
        decimal medication;
        decimal surgical;
        decimal labFee;
        decimal physicalRehabilitation;
        decimal totalCharges;
      
      
        public Form1()
        {
            InitializeComponent();
        }

        private int CalcStayCharges(int numberOfDays)
        {
            return numberOfDays * 350;
        }

        private decimal CalcTotalCharges(int stayCharges, decimal miscCharges)
        {
            return stayCharges + miscCharges;
        }

        private decimal CalcMiscCharges(decimal medication, decimal surgical, decimal labFee, 
            decimal physicalRehabilitation)
        {
            return medication + surgical + labFee + physicalRehabilitation;
        }

        private void btnCALCULATE_Click(object sender, EventArgs e)
        {
            // Number of days spent in hospital
            if (int.TryParse(tbxNumberOfDays.Text, out numberOfDays))
            {

            // Total medication charges
            if (decimal.TryParse(tbxMedication.Text, out medication))
            {

            // Surgical charges
            if (decimal.TryParse(tbxSurgical.Text, out surgical))
            {

            // Lab fees
            if (decimal.TryParse(tbxLabFee.Text, out labFee))
            {

            // Physical rehabilitation fees
            if (decimal.TryParse(tbxPhysicalRehabilitation.Text, out physicalRehabilitation))
            { 

            // Calculate and display stay charges
            tbxNumberOfDays.Text = numberOfDays.ToString("c");        

            // Display the misc charges
            tbxMedication.Text = medication.ToString("c");
            tbxSurgical.Text = surgical.ToString("c");    
            tbxLabFee.Text = labFee.ToString("c");
            tbxPhysicalRehabilitation.Text = physicalRehabilitation.ToString("c");

            // Display total and return as currency string
            tbxTotalCharges.Text = totalCharges.ToString("c");

                }
                else
                {
                    MessageBox.Show("Invalid input, please use numerica data.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input, please use numerica data.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input, please use numerica data.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input, please use numerica data.");
                    }
                }
                else
                {
                     MessageBox.Show("Invalid input, please use numerica data.");
                    }
                }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            // Clear all fields
            tbxNumberOfDays.Text = "";
            tbxLabFee.Text = "";
            tbxMedication.Text = "";
            tbxPhysicalRehabilitation.Text = "";
            tbxSurgical.Text = "";
            tbxTotalCharges.Text = "0";
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {

            // Close program
            Close();

        }
    }
}

