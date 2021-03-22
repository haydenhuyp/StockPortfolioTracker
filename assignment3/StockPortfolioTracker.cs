/*
 * Program ID: StockPortfolioTracker.cs
 * 
 * Purpose: to track and store data about stock transactions
 * 
 * Revision History: 
 *      Created by Huy Pham on March 16th 2021
 *      Edited by Huy Pham on March 17th 2021
 *      Edited by Huy Pham on March 18th 2021
 *      Edited by Huy Pham on March 19th 2021
 *      Edited by Huy Pham on March 20th 2021
 *      Finished on March 20th 2021
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;
using System.Globalization;

namespace assignment3
{
    public partial class StockPortfolioTracker : Form
    {
        public StockPortfolioTracker()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTicketSymbol.Text = "";
            txtCompany.Text = "";
            rbtnBuy.Checked = true;
            rtxtNote.Text = "";
            date.Value = DateTime.Now.Date;
            txtSharePrice.Text = "";
            txtNumberOfShares.Text = "";
            txtCommission.Text = "";
        }

        private void StockPortfolioTracker_Load(object sender, EventArgs e)
        {
            date.MaxDate = DateTime.Now;
            PathConfimed(false);
            rtxtMessages.Text = "Please enter the file name and path";
        }

        private void PathConfimed(bool isConfirmed)
        {
            switch (isConfirmed)
            {
                case false:
                    btnGetNewID.Enabled = false;
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDisplayTransactions.Enabled = false;
                    btnDeleteTransaction.Enabled = false;
                    btnEmptyFile.Enabled = false;
                    break;
                case true:
                    btnGetNewID.Enabled = true;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDisplayTransactions.Enabled = true;
                    btnDeleteTransaction.Enabled = true;
                    btnEmptyFile.Enabled = true;
                    break;

            }
        }

        string path = "";
        string fileName = "";
        string record = "";
        StreamReader reader;
        StreamWriter writer;

        private void btnPath_Click(object sender, EventArgs e)
        {
            rtxtMessages.Text = "";
            txtPath.Text = txtPath.Text.Trim();
            if (string.IsNullOrEmpty(txtPath.Text))
            {
                rtxtMessages.Text = "No file or path specified.";
                txtPath.Focus();
                PathConfimed(false);
            }
            else
            {
                if (txtPath.Text.LastIndexOf(".txt") == -1)
                {
                    rtxtMessages.Text = "No .txt file specified.";
                    txtPath.Focus();
                    PathConfimed(false);
                }
                else
                {
                    // Create 
                    if (string.IsNullOrWhiteSpace(txtPath.Text))
                    { rtxtMessages.Text = "No file or path specified"; }
                    else if (File.Exists(txtPath.Text))
                    {
                        PathConfimed(true);
                        fileName = txtPath.Text;
                        btnDisplayTransactions_Click(sender, e);
                        btnGetNewID_Click(sender, e);
                        rtxtMessages.Text = "File exists";
                    }
                    else
                    {
                        try
                        {
                            path = Path.GetDirectoryName(txtPath.Text);
                            fileName = Path.GetFileName(txtPath.Text);
                            if (!Directory.Exists(path) && path != "")
                                Directory.CreateDirectory(path);
                            File.Create(txtPath.Text).Dispose();
                            PathConfimed(true);
                            fileName = txtPath.Text;
                            btnDisplayTransactions_Click(sender, e);
                            btnGetNewID_Click(sender, e);
                            rtxtMessages.Text = "File created";
                        }
                        catch (Exception ex)
                        {
                            rtxtMessages.Text = "Exception creating the file: " + ex.Message;
                        }
                    }
                }
            }
        }
        DateTime dateFromFile;
        private void btnDisplayTransactions_Click(object sender, EventArgs e)
        {
            int transactionID, numberOfShares;
            double sharePrice, commission, totalAssetValue = 0, totalTransactionValue = 0;
            string ticketSymbol, company, type;
            rtxtMessages.Text = "";

            rtxtDisplay.Text = "Transaction ID".PadRight(17) + "Ticket Symbol\t" +
                "Company".PadRight(10) + "Type".PadRight(7) + "Date".PadRight(10) + "\tShare Price\tNumber of Shares\tCommission\tTotal Asset Value\tTotal Transaction Value\n";
            try
            {
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        record = "";
                        record = reader.ReadLine();
                        string[] fields = record.Split('\t');

                        transactionID = Int32.Parse(fields[0]);
                        ticketSymbol = fields[1];
                        company = fields[2];
                        type = fields[3];
                        dateFromFile = DateTime.Parse(fields[4]);
                        sharePrice = Double.Parse(fields[5]);
                        numberOfShares = int.Parse(fields[6]);
                        commission = Double.Parse(fields[7]);

                        totalAssetValue = sharePrice * numberOfShares;
                        totalTransactionValue = totalAssetValue - commission;

                        rtxtDisplay.Text += $"{transactionID.ToString("d4").PadRight(17)}{ticketSymbol.PadRight(13)}\t{company.PadRight(10)}{type.PadRight(7)}" +
                            $"{dateFromFile.ToString("yyyy/MM/dd").PadRight(11)}{sharePrice.ToString("c").PadRight(11)}" +
                            $"\t{numberOfShares.ToString().PadRight(16)}\t" +
                            $"{commission.ToString("c").PadRight(10)}\t{totalAssetValue.ToString("c").PadRight(17)}\t{totalTransactionValue.ToString("c")}\n";
                    }
                }
            }
            catch (Exception ex)
            {
                rtxtMessages.Text = "Error reading data from file: " + ex.Message;
            }
            finally
            {
                reader.Dispose();
            }
        }

        // check all input fields, if error occurs, display to the user
        private bool ValidateForm(string formType)
        {
            rtxtMessages.Text = "";
            bool isFocusTaken = false;
            switch (formType)
            {
                case "Add":
                case "Update":
                    {
                        if (string.IsNullOrWhiteSpace(txtID.Text))
                        {
                            txtID.Focus();
                            isFocusTaken = true;
                            rtxtMessages.Text = "Transaction ID must not be empty\n";
                        }
                        else
                        {
                            if (!int.TryParse(txtID.Text, out int result))
                            {
                                txtTransactionID.Focus();
                                isFocusTaken = true;
                                rtxtMessages.Text += "Transaction ID must be an integer.\n";
                            }
                        }
                        txtTicketSymbol.Text = txtTicketSymbol.Text.Trim();
                        if (string.IsNullOrWhiteSpace(txtTicketSymbol.Text))
                        {
                            rtxtMessages.Text += "Ticket Symbol must not be empty\n";
                            if (!isFocusTaken)
                            {
                                txtTicketSymbol.Focus();
                                isFocusTaken = true;
                            }
                        }

                        txtCompany.Text = txtCompany.Text.Trim();
                        if (string.IsNullOrWhiteSpace(txtCompany.Text))
                        {
                            rtxtMessages.Text += "Company field must not be empty\n";
                            if (!isFocusTaken)
                            {
                                txtCompany.Focus();
                                isFocusTaken = true;
                            }
                        }
                        //Date
                        if (date.Value > date.MaxDate)
                        {
                            rtxtMessages.Text += "Date must not be in the future\n";
                            if (!isFocusTaken)
                            {
                                date.Focus();
                                isFocusTaken = true;
                            }
                        }
                        if (string.IsNullOrWhiteSpace(txtSharePrice.Text))
                        {
                            rtxtMessages.Text += "Share Price must not be empty\n";
                            if (!isFocusTaken)
                            {
                                txtSharePrice.Focus();
                                isFocusTaken = true;
                            }
                        }
                        rtxtNote.Text = rtxtNote.Text.Trim();
                        if (!string.IsNullOrWhiteSpace(txtSharePrice.Text))
                        {
                            double result;
                            if (!double.TryParse(txtSharePrice.Text, out result))
                            {
                                rtxtMessages.Text += "Share price is not a number\n";
                                if (!isFocusTaken)
                                {
                                    txtSharePrice.Focus();
                                    isFocusTaken = true;
                                }
                            }
                            else
                            {
                                if (result <= 0)
                                {
                                    rtxtMessages.Text += "Share price must be larger than 0.\n";
                                    if (!isFocusTaken)
                                    {
                                        txtSharePrice.Focus();
                                        isFocusTaken = true;
                                    }
                                }
                            }
                        }
                        if (string.IsNullOrWhiteSpace(txtNumberOfShares.Text))
                        {
                            rtxtMessages.Text += "Number of shares must not be empty\n";
                            if (!isFocusTaken)
                            {
                                txtNumberOfShares.Focus();
                                isFocusTaken = true;
                            }
                        }
                        if (!string.IsNullOrWhiteSpace(txtNumberOfShares.Text))
                        {
                            int result;
                            if (!int.TryParse(txtNumberOfShares.Text, out result))
                            {
                                rtxtMessages.Text += "Number Of Shares is not a integer\n";
                                if (!isFocusTaken)
                                {
                                    txtNumberOfShares.Focus();
                                    isFocusTaken = true;
                                }
                            }
                            else
                            {
                                if (result <= 0)
                                {
                                    rtxtMessages.Text += "Number Of Shares must be larger than 0.\n";
                                    if (!isFocusTaken)
                                    {
                                        txtNumberOfShares.Focus();
                                        isFocusTaken = true;
                                    }
                                }
                            }
                        }
                        if (string.IsNullOrWhiteSpace(txtCommission.Text))
                        {
                            rtxtMessages.Text += "Commission must not be empty\n";
                            if (!isFocusTaken)
                            {
                                txtCommission.Focus();
                                isFocusTaken = true;
                            }
                        }
                        if (!string.IsNullOrWhiteSpace(txtCommission.Text))
                        {
                            double result;
                            if (!double.TryParse(txtCommission.Text, out result))
                            {
                                rtxtMessages.Text += "Commission is not a number\n";
                                if (!isFocusTaken)
                                {
                                    txtCommission.Focus();
                                    isFocusTaken = true;
                                }
                            }
                            else
                            {
                                if (result <= 0)
                                {
                                    rtxtMessages.Text += "Commission must be larger than 0.\n";
                                    if (!isFocusTaken)
                                    {
                                        txtCommission.Focus();
                                        isFocusTaken = true;
                                    }
                                }
                            }
                        }
                        break;
                    }
                case "Delete":
                    {
                        rtxtMessages.Text = "";
                        if (string.IsNullOrWhiteSpace(txtTransactionID.Text))
                        {
                            txtTransactionID.Focus();
                            rtxtMessages.Text = "Transaction ID must not be empty";
                            isFocusTaken = true;
                        }
                        else
                        {
                            if (!int.TryParse(txtTransactionID.Text, out int result))
                            {
                                txtTransactionID.Focus();
                                rtxtMessages.Text = "Transaction ID must be an integer.";
                                isFocusTaken = true;
                            }
                        }
                        break;
                    }
                default:
                    break;
            }
            if (!isFocusTaken)
            {
                return true;
            }
            else return false;
        }

        // add the record to the file, including the "note" field
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm("Add"))
            {
                int key = int.Parse(txtID.Text);
                bool isKeyFound = false;
                List<string> archiveList = new List<string>();
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        archiveList.Add(reader.ReadLine());
                    }
                }
                foreach (string field in archiveList)
                {
                    if (field.StartsWith(key.ToString("d4")))
                    {
                        isKeyFound = true;
                    }
                }

                if (!isKeyFound)
                {
                    record = "";
                    record = $"{int.Parse(txtID.Text).ToString("d4")}\t{txtTicketSymbol.Text}\t" +
                        $"{txtCompany.Text}\t";
                    if (rbtnBuy.Checked)
                    {
                        record += $"{rbtnBuy.Text}";
                    }
                    else
                    {
                        record += $"{rbtnSell.Text}";
                    }
                    rtxtNote.Text = rtxtNote.Text.Replace('\n', ' ');
                    record += $"\t{date.Value.ToString("yyyy/MM/dd")}\t{txtSharePrice.Text}" +
                        $"\t{txtNumberOfShares.Text}\t{txtCommission.Text}\t{rtxtNote.Text}";

                    try
                    {
                        using (writer = new StreamWriter(fileName, append: true))
                        {
                            writer.WriteLine(record);
                        }
                        btnDisplayTransactions_Click(sender, e);
                        rtxtMessages.Text = "Record Added\n";
                        btnClear_Click(sender, e);
                        btnGetNewID_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        rtxtMessages.Text = "Exception Writing Record: " + ex.Message;
                    }
                    finally
                    {
                        if (writer != null)
                        {
                            writer.Dispose();
                        }
                    }
                }
                else
                {
                    rtxtMessages.Text = "Transaction ID has already been taken.";
                    txtID.Focus();
                }
            }
        }

        // delete all transactions in file
        private void btnEmptyFile_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(fileName);
                File.Create(fileName).Dispose();
                btnDisplayTransactions_Click(sender, e);
                rtxtMessages.Text = "All transactions in file cleared.\n";
            }
            catch (Exception ex)
            {
                rtxtMessages.Text = "Exception Deleting Record File: " + ex.Message;
            }
        }

        // find the next valid transaction ID
        private void btnGetNewID_Click(object sender, EventArgs e)
        {
            int currentID = 0, highestID = 0;
            try
            {
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        record = "";
                        record = reader.ReadLine();
                        string[] fields = record.Split('\t');
                        currentID = Convert.ToInt32(fields[0]);
                        if (currentID > highestID)
                        {
                            highestID = currentID;
                        }
                    }
                }
                txtID.Text = (highestID + 1).ToString();
            }
            catch (Exception ex)
            {
                rtxtMessages.Text = "Exception getting new ID: " + ex.Message;
            }
        }

        // update an existing record based on user input, ID must be specified
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateForm("Update"))
            {
                int key = int.Parse(txtID.Text);
                bool isKeyFound = false;
                string updatedRecord = "";

                List<string> archiveList = new List<string>();
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        archiveList.Add(reader.ReadLine());
                    }
                }
                updatedRecord = $"{int.Parse(txtID.Text).ToString("d4")}\t{txtTicketSymbol.Text}\t" +
                    $"{txtCompany.Text}\t";
                if (rbtnBuy.Checked)
                {
                    updatedRecord += $"{rbtnBuy.Text}";
                }
                else
                {
                    updatedRecord += $"{rbtnSell.Text}";
                }

                updatedRecord += $"\t{date.Value.ToString("yyyy/MM/dd")}\t{txtSharePrice.Text}" +
                    $"\t{txtNumberOfShares.Text}\t{txtCommission.Text}\t{rtxtNote.Text.Replace('\n', ' ')}";
                try
                {
                    using (writer = new StreamWriter(fileName))
                    {
                        foreach (string field in archiveList)
                        {
                            if (field.StartsWith(key.ToString("d4")))
                            {
                                writer.WriteLine(updatedRecord);
                                isKeyFound = true;
                            }
                            else
                            {
                                writer.WriteLine(field);
                            }
                        }
                    }
                    btnDisplayTransactions_Click(sender, e);
                    if (isKeyFound)
                    {
                        btnClear_Click(sender, e);
                        rtxtMessages.Text = "Record updated";
                    }
                    else
                    {
                        rtxtMessages.Text = "Transaction ID not found.";
                        txtID.Focus();
                    }
                }
                catch (Exception ex)
                {
                    rtxtMessages.Text = "Exception updating record: " + ex.Message;
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Dispose();
                    }
                }
            }
        }

        // delete a record (a transaction)
        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(txtTransactionID.Text);
            bool isKeyFound = false;

            List<string> archiveList = new List<string>();
            using (reader = new StreamReader(fileName))
            {

                while (!reader.EndOfStream)
                {
                    archiveList.Add(reader.ReadLine());
                }
            }
            try
            {
                using (writer = new StreamWriter(fileName))
                {
                    foreach (string field in archiveList)
                    {
                        if (!field.StartsWith(key.ToString("d4")))
                        {
                            writer.WriteLine(field);
                        }
                        else
                        {
                            isKeyFound = true;
                        }
                    }
                }
                btnDisplayTransactions_Click(sender, e);
                if (isKeyFound)
                {
                    rtxtMessages.Text = "Record deleted";
                }
                else
                {
                    rtxtMessages.Text = "Transaction ID not found.";
                    txtTransactionID.Focus();
                }
            }
            catch (Exception ex)
            {
                rtxtMessages.Text = "Exception deleting record: " + ex.Message;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Dispose();
                }
            }
        }
    }
}
