using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Project
{
    public partial class AddRightTriangle : Form
    {
        // Create object
        Object rightTriangle = new Object();

        // List object
        List<Object> triangleObject = new List<Object>();

        public AddRightTriangle()
        {
            InitializeComponent();
        }

        private void btnCALCULATE_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables to hold sides
                double sideA = double.Parse(tbxSideA.Text);
                double sideB = double.Parse(tbxSideB.Text);
                double sideC = double.Parse(tbxSideC.Text);


                // Create DateTime object for time format
                DateTime.Now.ToString("yyyyMMddHHmmssfff");

                // Calculate Hypotenuse
                AddRightTriangle.Hypotenuse = Math.Sqrt(Math.Pow(sideA, sideB) +
                    Math.Pow(sideA, sideB));
                lblHypotenuse.Text = rightTriangle.Hypotenuse.ToString("#.##");

                // Calculate area
                rightTriangle.Area = sideA * sideB;
                tbxArea.Text = rightTriangle.Area.ToString();

                // Calculate perimeter
                rightTriangle.Perimeter = (sideA + sideB) + rightTriangle.Hypotenuse;
                tbxPerimeter.Text = rightTriangle.Perimeter.ToString("#.##");

                rightTriangle.Add(new Object()
                {
                    Hypotenuse = rightTriangle.Hypotenuse,
                    Area = rightTriangle.Area,
                    Perimeter = rightTriangle.Perimeter
                });

                // Increment
                rightTriangle.Count += 1;
            }
            catch (Exception)
            {
                // Display error message
                MessageBox.Show("Value must be numeric");
            }
        }

        // Return object
        public string getItem()
        {          
            {
                foreach (Object aShape in triangleObject)
                {
                    string date = DateTime.Now.ToString("HH:mm:ss MM/dd/yyyy");
                    return aShape.ToString() + " - " + date;
                }
            }
        }

        // Return count
        public string getCount()
        {
            return rightTriangle.Count.ToString();
        }
    }
}
