namespace SalesManagementApp.SalesMamagementPL
{
    partial class FrmCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearchCustomers = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesManagmentDBDataSet = new SalesManagementApp.SalesManagmentDBDataSet();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMovement = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.customersTableAdapter = new SalesManagementApp.SalesManagmentDBDataSetTableAdapters.CustomersTableAdapter();
            this.dgvAllCustomers = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesManagmentDBDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.cmbSearchCustomers);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(19, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 41);
            this.panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.MistyRose;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.Location = new System.Drawing.Point(237, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(375, 33);
            this.txtSearch.TabIndex = 0;
            // 
            // cmbSearchCustomers
            // 
            this.cmbSearchCustomers.BackColor = System.Drawing.Color.MistyRose;
            this.cmbSearchCustomers.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customersBindingSource, "CustomerName", true));
            this.cmbSearchCustomers.DisplayMember = "CustomerName";
            this.cmbSearchCustomers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.cmbSearchCustomers.FormattingEnabled = true;
            this.cmbSearchCustomers.Items.AddRange(new object[] {
            "رقم العميل",
            "أسم العميل"});
            this.cmbSearchCustomers.Location = new System.Drawing.Point(621, 4);
            this.cmbSearchCustomers.Name = "cmbSearchCustomers";
            this.cmbSearchCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearchCustomers.Size = new System.Drawing.Size(147, 33);
            this.cmbSearchCustomers.TabIndex = 1;
            this.cmbSearchCustomers.ValueMember = "CustomerName";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.salesManagmentDBDataSet;
            // 
            // salesManagmentDBDataSet
            // 
            this.salesManagmentDBDataSet.DataSetName = "SalesManagmentDBDataSet";
            this.salesManagmentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MistyRose;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.btnMovement);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdateCustomer);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(19, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 82);
            this.panel2.TabIndex = 1;
            // 
            // btnMovement
            // 
            this.btnMovement.BackColor = System.Drawing.Color.MistyRose;
            this.btnMovement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMovement.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnMovement.Location = new System.Drawing.Point(45, 5);
            this.btnMovement.Name = "btnMovement";
            this.btnMovement.Size = new System.Drawing.Size(134, 68);
            this.btnMovement.TabIndex = 7;
            this.btnMovement.Text = "الحركات";
            this.btnMovement.UseVisualStyleBackColor = false;
            this.btnMovement.Click += new System.EventHandler(this.btnMovement_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MistyRose;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Green;
            this.btnDelete.Location = new System.Drawing.Point(182, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 68);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.MistyRose;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdateCustomer.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(319, 5);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(134, 68);
            this.btnUpdateCustomer.TabIndex = 5;
            this.btnUpdateCustomer.Text = "تعديل";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MistyRose;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.Location = new System.Drawing.Point(459, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 68);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MistyRose;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.Location = new System.Drawing.Point(597, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 68);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // dgvAllCustomers
            // 
            this.dgvAllCustomers.AutoGenerateColumns = false;
            this.dgvAllCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.Phone,
            this.Address});
            this.dgvAllCustomers.DataSource = this.customersBindingSource;
            this.dgvAllCustomers.Location = new System.Drawing.Point(19, 64);
            this.dgvAllCustomers.Name = "dgvAllCustomers";
            this.dgvAllCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAllCustomers.Size = new System.Drawing.Size(791, 335);
            this.dgvAllCustomers.TabIndex = 8;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "رقم العميل";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 120;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "أسم العميل";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 280;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "التليفون";
            this.Phone.Name = "Phone";
            this.Phone.Width = 130;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "العنوان";
            this.Address.Name = "Address";
            this.Address.Width = 200;
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 493);
            this.Controls.Add(this.dgvAllCustomers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(845, 532);
            this.MinimumSize = new System.Drawing.Size(845, 532);
            this.Name = "FrmCustomers";
            this.Text = "قائمة العملاء";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesManagmentDBDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSearchCustomers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private SalesManagmentDBDataSet salesManagmentDBDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private SalesManagmentDBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnMovement;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAllCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}