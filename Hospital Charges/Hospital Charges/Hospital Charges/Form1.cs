using System;
using System.Windows.Forms;

namespace Hospital_Charges
{
    public partial class Form1 : Form
    {
        // Declare Variables
        int days, totalDays;
        decimal medication;
        decimal surgical;
        decimal lab;
        decimal rehabilitation;
        decimal totalMisc;
        decimal total;

        public Form1()
        {
            InitializeComponent();
        }

     private int CalcStayCharges(int days)
        { 
            return days * 350;
        }

        private decimal CalcMiscCharges(decimal medication, decimal surgical, decimal labfee,
            decimal physicalRehabilitation)
        {
             return medication + surgical + labfee + physicalRehabilitation;
        }

        private decimal CalcTotalCharges(decimal miscCharges, int stayCharges)
        {
              return miscCharges + stayCharges;
        }  

        private void btnCALCULATE_Click(object sender, EventArgs e)
        {
            // Number of days spent in hospital
            if (int.TryParse(tbxDays.Text, out days))
            {      
           
            // Total medication charges
            if (decimal.TryParse(tbxMedication.Text, out medication))
            {

            // Surgical charges
            if (decimal.TryParse(tbxSurgical.Text, out surgical))
            {

            // Lab fees
            if (decimal.TryParse(tbxLab.Text, out lab))
            { 

            // Physical rehabilitation fees
           if (decimal.TryParse(tbxRehabilitation.Text, out rehabilitation))
           {    
            
           // Calculate Stay Charges  
           totalDays = CalcStayCharges(days);
           tbxDays.Text = totalDays.ToString("c");
                                          
           //Calculate Misc Charges
           totalMisc = CalcMiscCharges(medication, surgical, lab, rehabilitation);
           tbxTotalCharges.Text = totalMisc.ToString("c");

           // Calculate total Charges
           total = CalcTotalCharges(totalMisc, totalDays);
                                
           // Display the Total Charges 
           tbxTotalCharges.Text = total.ToString("c");                          
           }
           else
            { 
             MessageBox.Show("Invalid input, please use numerical data.");
                    }
                }
           else
           {
           MessageBox.Show("Invalid input, please use numerical data.");
                     }
                 }
           else
           { 
           MessageBox.Show("Invalid input, please use numerical data.");
                     }
                 }
           else
           {
            MessageBox.Show("Invalid input, please use numerical data.");
                     }
                 }

          else
          {
          MessageBox.Show("Invalid input, please use numerical data.");
                     }
                 }
                
        
        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            // Clear all fields
            tbxDays.Text = "0";
            tbxLab.Text = "0";
            tbxMedication.Text = "0";
            tbxRehabilitation.Text = "0";
            tbxSurgical.Text = "0";
            tbxTotalCharges.Text = "0";
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {

            // Close program
            Close();

        }
    }
}



