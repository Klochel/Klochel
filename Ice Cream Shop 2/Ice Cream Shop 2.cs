using System;
using System.IO;
using System.Windows.Forms;

namespace Ice_Cream_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string flavor;

                //Open the data file for reading
                StreamReader inputFile = File.OpenText("G:\\Visual Programming\\Ice Cream Shop\\Ice Cream Shop\\Ice Cream Shop\\bin\\Debug\\flavors.txt");

                //Read all the lines in the file
                while (!inputFile.EndOfStream)
                {
                    //Read the next line
                    flavor = inputFile.ReadLine();

                    //Add it to the list box
                    lbxFlavors.Items.Add(flavor);
                }
                //Close the file
                inputFile.Close();

                //Display the number of flavors
                lbxFlavors.Text = "Choose one of the " +
                    lbxFlavors.Items.Count + " flavors available today!";
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ice Cream Shop",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            } 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Permanently delete this file's contents?",
                "Warning", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                // Delete all entries on file
                System.IO.File.WriteAllText("G:\\Visual Programming\\Ice Cream Shop\\Ice Cream Shop\\Ice Cream Shop\\bin\\Debug\\flavors.txt",
                   string.Empty);

                // Set lblEntries counter to 0
                lblChoices.Text = 0 + "flavor selections logged.";

                // Clear list box contents
                lbxFlavors.Items.Clear();

                // Display verification 
                MessageBox.Show("Ice cream list cleared");
            }
        }
    }
}