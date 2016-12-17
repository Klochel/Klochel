using shapes.shapes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace shapes
{
    public partial class AddRightTriangle : Form
    {
        //Create Object
        RightTriangle rightTriangle = new RightTriangle();

        // Create List object
        List<RightTriangle> rightTriangleShape = new List<RightTriangle>();

        public AddRightTriangle()
        {
            InitializeComponent();
        }

        private void btnAddTriangle_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables to hold sides
                double side1 = double.Parse(tbxSide1.Text);
                double side2 = double.Parse(tbxSide2.Text);
                double perimeter = double.Parse(tbxPerimeter.Text);
                double area = double.Parse(tbxArea.Text);
                double hypotenuse = double.Parse(tbxHypotenuse.Text);

                // Calculate Hypotenuse
                rightTriangle.Hypotenuse = Math.Sqrt(Math.Pow(side1, side2) +
                    Math.Pow(side1, side2));
                tbxHypotenuse.Text = rightTriangle.Perimeter.ToString("#.##");

                // Calculate area
                rightTriangle.Area = side1 * side2;
                lblArea.Text = rightTriangle.Area.ToString("#.##");

                // Calculate perimeter
                rightTriangle.Perimeter = (side1 + side2) + rightTriangle.Hypotenuse;
                tbxPerimeter.Text = rightTriangle.Perimeter.ToString("#.##");

                rightTriangle.Add(new Shape()
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

        // Return shape
        public string getItem()
        {
            foreach (Shape aShape in rightTriangleShape)
            {
                string date = DateTime.Now.ToString("HH:mm:ss MM/dd/yyyy");
                return date + " - " + aShape.ToString();
            }
            return null;
        }

        // Return count
        public string getCount()
        {
            return rightTriangle.ToString();
        }
    }

    internal class triangleShape
    {
    }
}