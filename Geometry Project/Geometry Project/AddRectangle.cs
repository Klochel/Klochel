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
    public partial class AddRectangle : Form
    {
        // Create Geometry object
        Rectangle rectangle = new Rectangle();

        // Create list object
        List<Rectangle> rectangleObject = new List<Rectangle>();

        public AddRectangle()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables to hold sides
                double length = double.Parse(tbxLength.Text);
                double width = double.Parse(tbxWidth.Text);

                // Create DateTime object for time format
                DateTime.Now.ToString("yyyyMMddHHmmssfff");

                // Calculate area
                rectangle.Area = length * width;
                lblArea.Text = rectangle.Area.ToString();

                // Calculate perimeter
                rectangle.Perimeter = (length + width) * 2;
                lblPerimeter.Text = rectangle.Perimeter.ToString("#.##");

                rectangleObject.Add(new Rectangle()
                {
                    Area = rectangle.Area,
                    Perimeter = rectangle.Perimeter
                });

                // Increment
                rectangle.Count += 1;
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
            foreach (Rectangle aShape in rectangleObject)
            {
                string date = DateTime.Now.ToString("HH:mm:ss MM/dd/yyyy");
                return aShape.ToString() + " - " + date;
            }
            return null;
        }

        // Return count
        public string getCount()
        {
            return rectangle.Count.ToString();
        }
    }
}