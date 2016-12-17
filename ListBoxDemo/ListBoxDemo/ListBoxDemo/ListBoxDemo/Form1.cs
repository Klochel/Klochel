using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb2_Click(object sender, EventArgs e)
        {

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string city;

            if (listBox1.SelectedIndex != -1)
            {
                city = listBox1.SelectedItem.ToString();

                switch (city)
                {
                    case "Denver":
                        lb2.Text = "Mountain";
                        break;
                    case "Mordor":
                        lb2.Text = "Middle Earth";
                        break;
                    case "Minneapolis":
                        lb2.Text = "Central";
                        break;
                    case "New York":
                        lb2.Text = "Eastern";
                        break;
                    case "San Francisco":
                        lb2.Text = "Pacific";
                        break;
                    case "Vin Diesel's House":
                        lb2.Text = "You're in the Xander Zone";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Select a city.");
            }
        }
    }
}
