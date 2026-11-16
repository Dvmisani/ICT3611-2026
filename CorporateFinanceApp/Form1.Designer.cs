namespace CorporateFinanceApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private System.Windows.Forms.BindingSource quarterlyBudgetsBindingSource;
        private System.Windows.Forms.Label lblCenterID;
        private System.Windows.Forms.TextBox txtCenterID;
        private System.Windows.Forms.Label lblSoftwareLicenses;
        private System.Windows.Forms.TextBox txtSoftwareLicenses;
        private System.Windows.Forms.Label lblOfficeSupplies;
        private System.Windows.Forms.TextBox txtOfficeSupplies;
        private System.Windows.Forms.Label lblTrainingCourses;
        private System.Windows.Forms.TextBox txtTrainingCourses;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShowProjection;
        private System.Windows.Forms.DataGridView dataGridViewProjection;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.quarterlyBudgetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCenterID = new System.Windows.Forms.Label();
            this.txtCenterID = new System.Windows.Forms.TextBox();
            this.lblSoftwareLicenses = new System.Windows.Forms.Label();
            this.txtSoftwareLicenses = new System.Windows.Forms.TextBox();
            this.lblOfficeSupplies = new System.Windows.Forms.Label();
            this.txtOfficeSupplies = new System.Windows.Forms.TextBox();
            this.lblTrainingCourses = new System.Windows.Forms.Label();
            this.txtTrainingCourses = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowProjection = new System.Windows.Forms.Button();
            this.dataGridViewProjection = new System.Windows.Forms.DataGridView();
            this.quarterlyBudgetsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.quarterlyBudgetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarterlyBudgetsBindingNavigator)).BeginInit();
            this.quarterlyBudgetsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCenterID
            // 
            this.lblCenterID.AutoSize = true;
            this.lblCenterID.Location = new System.Drawing.Point(20, 45);
            this.lblCenterID.Name = "lblCenterID";
            this.lblCenterID.Size = new System.Drawing.Size(65, 16);
            this.lblCenterID.TabIndex = 11;
            this.lblCenterID.Text = "Center ID:";
            // 
            // txtCenterID
            // 
            this.txtCenterID.Location = new System.Drawing.Point(160, 45);
            this.txtCenterID.Name = "txtCenterID";
            this.txtCenterID.Size = new System.Drawing.Size(150, 22);
            this.txtCenterID.TabIndex = 1;
            // 
            // lblSoftwareLicenses
            // 
            this.lblSoftwareLicenses.AutoSize = true;
            this.lblSoftwareLicenses.Location = new System.Drawing.Point(20, 80);
            this.lblSoftwareLicenses.Name = "lblSoftwareLicenses";
            this.lblSoftwareLicenses.Size = new System.Drawing.Size(119, 16);
            this.lblSoftwareLicenses.TabIndex = 10;
            this.lblSoftwareLicenses.Text = "Software Licenses:";
            // 
            // txtSoftwareLicenses
            // 
            this.txtSoftwareLicenses.Location = new System.Drawing.Point(160, 77);
            this.txtSoftwareLicenses.Name = "txtSoftwareLicenses";
            this.txtSoftwareLicenses.Size = new System.Drawing.Size(150, 22);
            this.txtSoftwareLicenses.TabIndex = 2;
            // 
            // lblOfficeSupplies
            // 
            this.lblOfficeSupplies.AutoSize = true;
            this.lblOfficeSupplies.Location = new System.Drawing.Point(20, 115);
            this.lblOfficeSupplies.Name = "lblOfficeSupplies";
            this.lblOfficeSupplies.Size = new System.Drawing.Size(100, 16);
            this.lblOfficeSupplies.TabIndex = 9;
            this.lblOfficeSupplies.Text = "Office Supplies:";
            // 
            // txtOfficeSupplies
            // 
            this.txtOfficeSupplies.Location = new System.Drawing.Point(160, 112);
            this.txtOfficeSupplies.Name = "txtOfficeSupplies";
            this.txtOfficeSupplies.Size = new System.Drawing.Size(150, 22);
            this.txtOfficeSupplies.TabIndex = 3;
            // 
            // lblTrainingCourses
            // 
            this.lblTrainingCourses.AutoSize = true;
            this.lblTrainingCourses.Location = new System.Drawing.Point(20, 150);
            this.lblTrainingCourses.Name = "lblTrainingCourses";
            this.lblTrainingCourses.Size = new System.Drawing.Size(112, 16);
            this.lblTrainingCourses.TabIndex = 8;
            this.lblTrainingCourses.Text = "Training Courses:";
            // 
            // txtTrainingCourses
            // 
            this.txtTrainingCourses.Location = new System.Drawing.Point(160, 147);
            this.txtTrainingCourses.Name = "txtTrainingCourses";
            this.txtTrainingCourses.Size = new System.Drawing.Size(150, 22);
            this.txtTrainingCourses.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(160, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Budget";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowProjection
            // 
            this.btnShowProjection.Location = new System.Drawing.Point(330, 190);
            this.btnShowProjection.Name = "btnShowProjection";
            this.btnShowProjection.Size = new System.Drawing.Size(180, 30);
            this.btnShowProjection.TabIndex = 6;
            this.btnShowProjection.Text = "Show Annual Projection";
            this.btnShowProjection.UseVisualStyleBackColor = true;
            this.btnShowProjection.Click += new System.EventHandler(this.btnShowProjection_Click);
            // 
            // dataGridViewProjection
            // 
            this.dataGridViewProjection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjection.Location = new System.Drawing.Point(20, 240);
            this.dataGridViewProjection.Name = "dataGridViewProjection";
            this.dataGridViewProjection.RowHeadersWidth = 51;
            this.dataGridViewProjection.Size = new System.Drawing.Size(600, 250);
            this.dataGridViewProjection.TabIndex = 7;
            // 
            // quarterlyBudgetsBindingNavigator
            // 
            this.quarterlyBudgetsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.quarterlyBudgetsBindingNavigator.BindingSource = this.quarterlyBudgetsBindingSource;
            this.quarterlyBudgetsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.quarterlyBudgetsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.quarterlyBudgetsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.quarterlyBudgetsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.quarterlyBudgetsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.quarterlyBudgetsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.quarterlyBudgetsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.quarterlyBudgetsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.quarterlyBudgetsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.quarterlyBudgetsBindingNavigator.Name = "quarterlyBudgetsBindingNavigator";
            this.quarterlyBudgetsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.quarterlyBudgetsBindingNavigator.Size = new System.Drawing.Size(650, 27);
            this.quarterlyBudgetsBindingNavigator.TabIndex = 12;
            this.quarterlyBudgetsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(650, 520);
            this.Controls.Add(this.quarterlyBudgetsBindingNavigator);
            this.Controls.Add(this.dataGridViewProjection);
            this.Controls.Add(this.btnShowProjection);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTrainingCourses);
            this.Controls.Add(this.lblTrainingCourses);
            this.Controls.Add(this.txtOfficeSupplies);
            this.Controls.Add(this.lblOfficeSupplies);
            this.Controls.Add(this.txtSoftwareLicenses);
            this.Controls.Add(this.lblSoftwareLicenses);
            this.Controls.Add(this.txtCenterID);
            this.Controls.Add(this.lblCenterID);
            this.Name = "Form1";
            this.Text = "Corporate Finance - Budget Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quarterlyBudgetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quarterlyBudgetsBindingNavigator)).EndInit();
            this.quarterlyBudgetsBindingNavigator.ResumeLayout(false);
            this.quarterlyBudgetsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.BindingNavigator quarterlyBudgetsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}