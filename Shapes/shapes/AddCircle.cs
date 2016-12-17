using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace shapes
{
    public partial class AddCircle : Form
    {
        // Create object
        Circle circle = new Circle();

        // Create list object
        List<Circle> circleShape = new List<Circle>();

        public AddCircle()
        {
            InitializeComponent();
        }
        private void btnAddCircle_Click(object sender, EventArgs e)
        {
            try
            {             
           
                const double PI = 3.14;

                // Create DateTime object for time format
                DateTime.Now.ToString("yyyyMMddHHmmssfff");

                // Variables to hold sides
                double radius = double.Parse(tbxRadius.Text);
                double diameter = double.Parse(tbxDiameter.Text);


                // Calculate area
                circle.Area = PI * Math.Pow(radius, 2);
                tbxArea.Text = circle.Area.ToString();

                // Calculate perimeter
                circle.Circumference = 2 * (PI * radius);
                tbxCircumference.Text = circle.ToString();

                circleShape.Add(new Circle()
                {
                    Area = circle.Area,
                    Circumference = circle.Circumference
                });
            }
            catch (Exception)
            {
                // Display error message
                MessageBox.Show("Value must be numeric");
            }
        }

        // Return Item
        public string getItem()
        {
            foreach (Circle aShape in circleShape)
            {
                string date = DateTime.Now.ToString("HH:mm:ss MM/dd/yyyy");
                return date + " - " + aShape.ToString();
            }
            return null;
        }

        // Return count
        public string getCount()
        {
            return circle.ToString();
        }
    }
}



