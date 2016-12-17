using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss_Project
{
  
    public partial class Form1 : Form
    {
          //Intialize heads and tails counters/percentages
    int headsCounter = 0;
    int tailsCounter = 0;
    double headsPercentage = 0;
    double tailsPercentage = 0;
    int numOfFlips = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTossCoin_Click(object sender, EventArgs e)
        {

            //Create random object toss of coin
            Random rand = new Random();

            //Toss the coin
            int toss = rand.Next(2);

            //Display the results
            if (toss == 0)
            {
                //Display heads
                pbxHeads.Visible = true;
                pbxTails.Visible = false;

                //Increament heads
                headsCounter++;
                numOfFlips++;
                tbxNumOfHeads.Text = headsCounter.ToString();
            }
            else
            {
                //Display tails
                pbxHeads.Visible = false;
                pbxTails.Visible = true;

                //Increament tails
                tailsCounter++;
                numOfFlips++;
                tbxNumOfTails.Text = tailsCounter.ToString();
            }

            //Calculate the percentage of sides
            tailsPercentage = (1.0 * tailsCounter / numOfFlips) * 100;
            headsPercentage = (1.0 * headsCounter / numOfFlips) * 100;

            //Display
            tbxPercentOfHeads.Text = headsPercentage.ToString("#.##");
            tbxPercentOfTails.Text = tailsPercentage.ToString("#.##");
        }

    }
    }

