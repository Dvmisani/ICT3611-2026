namespace AccountingManagement
{
    partial class frmAccounting
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new System.Windows.Forms.Label();
            btnLoad = new System.Windows.Forms.Button();
            lstResults = new System.Windows.Forms.ListBox();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(150, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Corporate Expense Analysis";

            // btnLoad
            btnLoad.Location = new System.Drawing.Point(180, 60);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(120, 30);
            btnLoad.Text = "Load & Analyse";
            btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // lstResults
            lstResults.Font = new System.Drawing.Font("Courier New", 9F);
            lstResults.Location = new System.Drawing.Point(20, 110);
            lstResults.Name = "lstResults";
            lstResults.Size = new System.Drawing.Size(540, 250);

            // frmAccounting
            ClientSize = new System.Drawing.Size(590, 400);
            Controls.Add(lblTitle);
            Controls.Add(btnLoad);
            Controls.Add(lstResults);
            Name = "frmAccounting";
            Text = "Accounting Management - Option 4";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lstResults;
    }
}