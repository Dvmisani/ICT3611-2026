using System;
using System.IO;
using System.Windows.Forms;

namespace AccountingManagement
{
    public partial class frmAccounting : Form
    {
        private const int MONTHS = 4;
        private const int CATS = 5;

        private readonly string[] catNames =
        {
            "Payroll & Benefits", "Office Rent",
            "Utilities & Comm", "Marketing",
            "Software Subscriptions"
        };

        public frmAccounting()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string filePath = "array.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("array.txt not found!",
                    "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double[,] data = new double[MONTHS, CATS];
            string[] monthNames = new string[MONTHS];

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                for (int row = 0; row < MONTHS; row++)
                {
                    string[] parts = lines[row].Split(',');
                    monthNames[row] = parts[0].Trim();

                    for (int col = 0; col < CATS; col++)
                        data[row, col] = double.Parse(parts[col + 1].Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file:\n" + ex.Message,
                    "Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate row totals
            double[] rowTotals = new double[MONTHS];
            for (int row = 0; row < MONTHS; row++)
            {
                double sum = 0;
                for (int col = 0; col < CATS; col++)
                    sum += data[row, col];
                rowTotals[row] = sum;
            }

            // Find highest month
            int maxIndex = 0;
            double maxTotal = rowTotals[0];
            for (int i = 1; i < MONTHS; i++)
            {
                if (rowTotals[i] > maxTotal)
                {
                    maxTotal = rowTotals[i];
                    maxIndex = i;
                }
            }

            // Display results
            lstResults.Items.Clear();
            lstResults.Items.Add("=== Monthly Expense Totals (ZAR thousands) ===");
            lstResults.Items.Add("");

            for (int row = 0; row < MONTHS; row++)
            {
                lstResults.Items.Add(
                    $"{monthNames[row],-10}  Total: R {rowTotals[row]:N0},000");
            }

            lstResults.Items.Add("");
            lstResults.Items.Add(new string('-', 48));
            lstResults.Items.Add(
                $"Highest Expense Month: {monthNames[maxIndex]} (R {maxTotal:N0},000)");
        }
    }
}