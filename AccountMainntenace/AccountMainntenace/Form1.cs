using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace AccountMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string account;
                StreamReader inputFile = File.OpenText("accts.txt");

                while (!inputFile.EndOfStream)
                {
                    // Read line and store in account variable
                    account = inputFile.ReadLine();

                    // Display list box elements
                    AccountListBox.Items.Add(account);
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Account Maintenance",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnAddAcount_Click(object sender, EventArgs e)
        {
            int accountAdd;
            // Check if entered entry is an int
            if (int.TryParse(tbxAccountLookup.Text, out accountAdd))
            {
                // Check if entry is at least 5 digits long
                if (tbxAccountLookup.TextLength > 4)
                {
                    // If not found in list, add item
                    if ((!AccountListBox.Items.Contains(tbxAccountLookup.Text)))
                    {
                        // Display message and add item to listBox
                        MessageBox.Show("Non-duplicate entry entered, adding it to the maintenance log",
                            "Account Maintenance");
                        AccountListBox.Items.Add(tbxAccountLookup.Text);
                        tbxAccountLookup.Text = "0";
                    }
                    else
                    {
                        // Item already in list, display error
                        MessageBox.Show("Account log already contains entry", "Warning");
                    }
                }
                else
                {
                    MessageBox.Show("Account must be at least 5 digits long", "Warning");
                }
            }
            else
            {
                MessageBox.Show("Entry is not an integer, please enter 5 digits", "Warning");
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            int accountVerify;
            // Check if entered entry is in list
            if (int.TryParse(tbxAccountLookup.Text, out accountVerify))
            {
                // Make sure entered entry is at least 5 digits
                if (tbxAccountLookup.TextLength > 4)
                {
                    if ((AccountListBox.Items.Contains(tbxAccountLookup.Text)))
                    {
                        // Display message and verify item was found
                        MessageBox.Show("Entry was found in maintenance log", "Account Maintenance");
                        tbxAccountLookup.Text = "0";
                    }
                    else
                    {
                        // Item already in list, display error
                        MessageBox.Show("Entered account does not exist in maintenance log", "Warning");
                    }
                }
                else
                {
                    MessageBox.Show("Account must be at least 5 digits long", "Warning");
                }
            }
            else
            {
                MessageBox.Show("Entry is not an integer, please enter 5 digits", "Warning");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int accountDelete;
            if (int.TryParse(tbxAccountLookup.Text, out accountDelete))
            {
                // Make sure entered entry is at least 5 digits
                if (tbxAccountLookup.TextLength > 4)
                {
                    if ((AccountListBox.Items.Contains(tbxAccountLookup.Text)))
                    {
                        // Display message and verify if account is to be deleted
                        DialogResult dialogResult = MessageBox.Show(
                            "Permanently delete this account from the maintenance log?", "Warning",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.OK)
                        {
                            // Remove entered entry from log file
                            AccountListBox.Items.Remove(tbxAccountLookup.Text);
                            tbxAccountLookup.Text = "0";
                        }
                    }
                    else
                    {
                        // Item already in list, display error
                        MessageBox.Show("Entered account does not exist in maintenance log", "Warning");
                    }
                }
                else
                {
                    MessageBox.Show("Account must be at least 5 digits long", "Warning");
                }
            }
            else
            {
                MessageBox.Show("Entry is not an integer, please enter 5 digits", "Warning");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                          "Permanently delete ALL accounts from the maintenance log?", "Warning",
                          MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                // Remove all items from listBox
                AccountListBox.Items.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                // Write contents of listBox to file
                StreamWriter outputFile = new StreamWriter("accts.txt");

                // Parse through listBox and add items to outputFile
                foreach (var accounts in AccountListBox.Items)
                {
                    outputFile.WriteLine(accounts);
                }
                outputFile.Close();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Account Maintenance",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
