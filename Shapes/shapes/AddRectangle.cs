using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace shapes
{
    public partial class AddRectangle : Form
    {
        // Create object
        Rectangle rectangle = new Rectangle();

        // Create list object
        List<Rectangle> rectangleShape = new List<Rectangle>();

        public AddRectangle()
        {
            InitializeComponent();
        }

        private void btnAddRectangle_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables to hold sides
                double length = double.Parse(tbxLength.Text);
                double width = double.Parse(tbxWidth.Text);
                double area = double.Parse(tbxArea.Text);
                double perimeter = double.Parse(tbxPerimeter.Text);
                //int count;                              

                // Calculate area
                area = length * width;
                tbxArea.Text = rectangle.ToString();

                // Calculate perimeter
                perimeter = (length + width) * 2;
                tbxPerimeter.Text = rectangle.ToString();

                rectangleShape.Add(new Rectangle());

                // Create DateTime object for time format
                DateTime.Now.ToString("yyyyMMddHHmmssfff");

                // Increment
                //rectangle.Count += 1;
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
            foreach (Rectangle aShape in rectangleShape)
            {
                string date = DateTime.Now.ToString("HH:mm:ss MM/dd/yyyy");
                return date + " - " + aShape.ToString();
            }
            return null;
        }
    
        // Return count
        public string getCount()
        {
            return rectangle.ToString();
        }      

        }
    }
