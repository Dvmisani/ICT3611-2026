using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace CorporateFinanceApp
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection;
        private OleDbDataAdapter costCentersAdapter;
        private OleDbDataAdapter quarterlyBudgetsAdapter;
        private DataSet dataSet;

        // Adjust this path to wherever CorporateFinance.accdb sits relative to your exe
        private string dbPath = Path.Combine(Application.StartupPath, "CorporateFinance.accdb");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
            connection = new OleDbConnection(connString);

            dataSet = new DataSet();

            // CostCenters
            costCentersAdapter = new OleDbDataAdapter("SELECT * FROM CostCenters", connection);
            costCentersAdapter.Fill(dataSet, "CostCenters");

            // QuarterlyBudgets
            quarterlyBudgetsAdapter = new OleDbDataAdapter("SELECT * FROM QuarterlyBudgets", connection);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(quarterlyBudgetsAdapter);
            quarterlyBudgetsAdapter.Fill(dataSet, "QuarterlyBudgets");

            quarterlyBudgetsBindingSource.DataSource = dataSet;
            quarterlyBudgetsBindingSource.DataMember = "QuarterlyBudgets";

            quarterlyBudgetsBindingNavigator.BindingSource = quarterlyBudgetsBindingSource;

            // Bind text boxes to fields
            txtCenterID.DataBindings.Clear();
            txtSoftwareLicenses.DataBindings.Clear();
            txtOfficeSupplies.DataBindings.Clear();
            txtTrainingCourses.DataBindings.Clear();

            txtCenterID.DataBindings.Add("Text", quarterlyBudgetsBindingSource, "centerID");
            txtSoftwareLicenses.DataBindings.Add("Text", quarterlyBudgetsBindingSource, "softwareLicenses");
            txtOfficeSupplies.DataBindings.Add("Text", quarterlyBudgetsBindingSource, "officeSupplies");
            txtTrainingCourses.DataBindings.Add("Text", quarterlyBudgetsBindingSource, "trainingCourses");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                quarterlyBudgetsBindingSource.EndEdit();

                OleDbCommandBuilder cb = new OleDbCommandBuilder(quarterlyBudgetsAdapter);
                quarterlyBudgetsAdapter.Update(dataSet, "QuarterlyBudgets");

                MessageBox.Show("Budget saved successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving budget: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowProjection_Click(object sender, EventArgs e)
        {
            DataTable results = new DataTable();
            results.Columns.Add("Division Name", typeof(string));
            results.Columns.Add("Annualized Expense Projection", typeof(decimal));

            DataTable costCenters = dataSet.Tables["CostCenters"];
            DataTable budgets = dataSet.Tables["QuarterlyBudgets"];

            foreach (DataRow budgetRow in budgets.Rows)
            {
                int centerID = Convert.ToInt32(budgetRow["centerID"]);

                DataRow[] matches = costCenters.Select($"centerID = {centerID}");
                if (matches.Length > 0)
                {
                    string divisionName = matches[0]["divisionName"].ToString();

                    decimal software = budgetRow["softwareLicenses"] != DBNull.Value
                        ? Convert.ToDecimal(budgetRow["softwareLicenses"]) : 0;
                    decimal supplies = budgetRow["officeSupplies"] != DBNull.Value
                        ? Convert.ToDecimal(budgetRow["officeSupplies"]) : 0;
                    decimal training = budgetRow["trainingCourses"] != DBNull.Value
                        ? Convert.ToDecimal(budgetRow["trainingCourses"]) : 0;

                    decimal projection = (software * 4) + (supplies * 12) + (training * 2);

                    results.Rows.Add(divisionName, projection);
                }
            }

            dataGridViewProjection.DataSource = results;
        }
    }
}