namespace SalesManagementApp.UserControls
{
    partial class ctrlCustomers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearchCustomers = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAllCustomers = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.إستمرارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إضافةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إلغاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الحركاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesManagmentDBDataSet = new SalesManagementApp.SalesManagmentDBDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new SalesManagementApp.SalesManagmentDBDataSetTableAdapters.CustomersTableAdapter();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbBoxAddEditCustomer = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHouseNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGadaNumber = new System.Windows.Forms.TextBox();
            this.txtStreetNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBlockNaumber = new System.Windows.Forms.TextBox();
            this.txtAreaName = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grbBoxCustomersMovements = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCustomerPhoneNumber = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnReceivedVoucher = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnReturnInvoices = new System.Windows.Forms.Button();
            this.btnSalesInvoices = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnReturnPurchacesInvoice = new System.Windows.Forms.Button();
            this.btnPurchecesInvoices = new System.Windows.Forms.Button();
            this.btnPaymentVoucher = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCustomers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesManagmentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.grbBoxAddEditCustomer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbBoxCustomersMovements.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(507, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "إدراة العملاء ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(9, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 37);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.dgvAllCustomers);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(369, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(743, 488);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إدارة العملاء";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(11, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(128, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(375, 27);
            this.txtSearch.TabIndex = 0;
            // 
            // cmbSearchCustomers
            // 
            this.cmbSearchCustomers.BackColor = System.Drawing.SystemColors.Control;
            this.cmbSearchCustomers.DisplayMember = "CustomerName";
            this.cmbSearchCustomers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.cmbSearchCustomers.FormattingEnabled = true;
            this.cmbSearchCustomers.Items.AddRange(new object[] {
            "رقم العميل",
            "أسم العميل"});
            this.cmbSearchCustomers.Location = new System.Drawing.Point(566, 5);
            this.cmbSearchCustomers.Name = "cmbSearchCustomers";
            this.cmbSearchCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearchCustomers.Size = new System.Drawing.Size(148, 27);
            this.cmbSearchCustomers.TabIndex = 1;
            this.cmbSearchCustomers.ValueMember = "CustomerName";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(358, 447);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 33);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.cmbSearchCustomers);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Location = new System.Drawing.Point(6, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 41);
            this.panel3.TabIndex = 9;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
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
            this.dgvAllCustomers.Location = new System.Drawing.Point(6, 65);
            this.dgvAllCustomers.Name = "dgvAllCustomers";
            this.dgvAllCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAllCustomers.Size = new System.Drawing.Size(723, 378);
            this.dgvAllCustomers.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إستمرارToolStripMenuItem,
            this.إضافةToolStripMenuItem,
            this.إلغاءToolStripMenuItem,
            this.تعديلToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.الحركاتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // إستمرارToolStripMenuItem
            // 
            this.إستمرارToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.إستمرارToolStripMenuItem.Name = "إستمرارToolStripMenuItem";
            this.إستمرارToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.إستمرارToolStripMenuItem.Text = "إستمرار";
            this.إستمرارToolStripMenuItem.Click += new System.EventHandler(this.إستمرارToolStripMenuItem_Click);
            // 
            // إضافةToolStripMenuItem
            // 
            this.إضافةToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.إضافةToolStripMenuItem.Name = "إضافةToolStripMenuItem";
            this.إضافةToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.إضافةToolStripMenuItem.Text = "إضافة";
            this.إضافةToolStripMenuItem.Click += new System.EventHandler(this.إضافةToolStripMenuItem_Click);
            // 
            // إلغاءToolStripMenuItem
            // 
            this.إلغاءToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.إلغاءToolStripMenuItem.Name = "إلغاءToolStripMenuItem";
            this.إلغاءToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.إلغاءToolStripMenuItem.Text = "إلغاء";
            this.إلغاءToolStripMenuItem.Click += new System.EventHandler(this.إلغاءToolStripMenuItem_Click);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // الحركاتToolStripMenuItem
            // 
            this.الحركاتToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.الحركاتToolStripMenuItem.Name = "الحركاتToolStripMenuItem";
            this.الحركاتToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.الحركاتToolStripMenuItem.Text = "الحركات";
            this.الحركاتToolStripMenuItem.Click += new System.EventHandler(this.الحركاتToolStripMenuItem_Click);
            // 
            // salesManagmentDBDataSet
            // 
            this.salesManagmentDBDataSet.DataSetName = "SalesManagmentDBDataSet";
            this.salesManagmentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.salesManagmentDBDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "رقم العميل";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "أسم العميل";
            this.CustomerName.Name = "CustomerName";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "رقم التليفون";
            this.Phone.Name = "Phone";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "العنوان";
            this.Address.Name = "Address";
            // 
            // grbBoxAddEditCustomer
            // 
            this.grbBoxAddEditCustomer.Controls.Add(this.groupBox2);
            this.grbBoxAddEditCustomer.Controls.Add(this.btnCancel);
            this.grbBoxAddEditCustomer.Controls.Add(this.txtCustomerName);
            this.grbBoxAddEditCustomer.Controls.Add(this.label2);
            this.grbBoxAddEditCustomer.Controls.Add(this.txtCustomerPhoneNumber);
            this.grbBoxAddEditCustomer.Controls.Add(this.btnSave);
            this.grbBoxAddEditCustomer.Controls.Add(this.label8);
            this.grbBoxAddEditCustomer.Location = new System.Drawing.Point(374, 546);
            this.grbBoxAddEditCustomer.Name = "grbBoxAddEditCustomer";
            this.grbBoxAddEditCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbBoxAddEditCustomer.Size = new System.Drawing.Size(725, 250);
            this.grbBoxAddEditCustomer.TabIndex = 3;
            this.grbBoxAddEditCustomer.TabStop = false;
            this.grbBoxAddEditCustomer.Text = "إضافة عميل / تعديل بيانات عميل";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(268, 551);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(269, 76);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.SystemColors.Control;
            this.txtNotes.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtNotes.Location = new System.Drawing.Point(28, 139);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(580, 49);
            this.txtNotes.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(617, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "أسم المنطقة";
            // 
            // txtHouseNumber
            // 
            this.txtHouseNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtHouseNumber.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtHouseNumber.Location = new System.Drawing.Point(454, 104);
            this.txtHouseNumber.Multiline = true;
            this.txtHouseNumber.Name = "txtHouseNumber";
            this.txtHouseNumber.Size = new System.Drawing.Size(154, 29);
            this.txtHouseNumber.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(652, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "المنزل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(327, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "رقم الجادة";
            // 
            // txtGadaNumber
            // 
            this.txtGadaNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtGadaNumber.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtGadaNumber.Location = new System.Drawing.Point(172, 63);
            this.txtGadaNumber.Multiline = true;
            this.txtGadaNumber.Name = "txtGadaNumber";
            this.txtGadaNumber.Size = new System.Drawing.Size(127, 29);
            this.txtGadaNumber.TabIndex = 28;
            // 
            // txtStreetNumber
            // 
            this.txtStreetNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtStreetNumber.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtStreetNumber.Location = new System.Drawing.Point(454, 63);
            this.txtStreetNumber.Multiline = true;
            this.txtStreetNumber.Name = "txtStreetNumber";
            this.txtStreetNumber.Size = new System.Drawing.Size(154, 29);
            this.txtStreetNumber.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(652, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "الشارع";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(327, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "رقم القطعة";
            // 
            // txtBlockNaumber
            // 
            this.txtBlockNaumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtBlockNaumber.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtBlockNaumber.Location = new System.Drawing.Point(172, 24);
            this.txtBlockNaumber.Multiline = true;
            this.txtBlockNaumber.Name = "txtBlockNaumber";
            this.txtBlockNaumber.Size = new System.Drawing.Size(127, 29);
            this.txtBlockNaumber.TabIndex = 24;
            // 
            // txtAreaName
            // 
            this.txtAreaName.BackColor = System.Drawing.SystemColors.Control;
            this.txtAreaName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtAreaName.Location = new System.Drawing.Point(454, 24);
            this.txtAreaName.Multiline = true;
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(154, 29);
            this.txtAreaName.TabIndex = 22;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.Control;
            this.txtCustomerName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtCustomerName.Location = new System.Drawing.Point(7, 19);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(299, 29);
            this.txtCustomerName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(334, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "أسم العميل";
            // 
            // txtCustomerPhoneNumber
            // 
            this.txtCustomerPhoneNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtCustomerPhoneNumber.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtCustomerPhoneNumber.Location = new System.Drawing.Point(461, 19);
            this.txtCustomerPhoneNumber.Multiline = true;
            this.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            this.txtCustomerPhoneNumber.Size = new System.Drawing.Size(154, 29);
            this.txtCustomerPhoneNumber.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(542, 551);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(277, 76);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(636, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "رقم العميل";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAreaName);
            this.groupBox2.Controls.Add(this.txtNotes);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtHouseNumber);
            this.groupBox2.Controls.Add(this.txtBlockNaumber);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtGadaNumber);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtStreetNumber);
            this.groupBox2.Location = new System.Drawing.Point(6, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 196);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العــــــــنوان";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(631, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "ملاحظات";
            // 
            // grbBoxCustomersMovements
            // 
            this.grbBoxCustomersMovements.Controls.Add(this.label12);
            this.grbBoxCustomersMovements.Controls.Add(this.button3);
            this.grbBoxCustomersMovements.Controls.Add(this.btnReturnPurchacesInvoice);
            this.grbBoxCustomersMovements.Controls.Add(this.btnPurchecesInvoices);
            this.grbBoxCustomersMovements.Controls.Add(this.btnPaymentVoucher);
            this.grbBoxCustomersMovements.Controls.Add(this.btnReceivedVoucher);
            this.grbBoxCustomersMovements.Controls.Add(this.btnReports);
            this.grbBoxCustomersMovements.Controls.Add(this.btnReturnInvoices);
            this.grbBoxCustomersMovements.Controls.Add(this.btnSalesInvoices);
            this.grbBoxCustomersMovements.Controls.Add(this.label10);
            this.grbBoxCustomersMovements.Controls.Add(this.lblCustomerPhoneNumber);
            this.grbBoxCustomersMovements.Controls.Add(this.label11);
            this.grbBoxCustomersMovements.Controls.Add(this.lblCustomerName);
            this.grbBoxCustomersMovements.Location = new System.Drawing.Point(22, 61);
            this.grbBoxCustomersMovements.Name = "grbBoxCustomersMovements";
            this.grbBoxCustomersMovements.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbBoxCustomersMovements.Size = new System.Drawing.Size(341, 735);
            this.grbBoxCustomersMovements.TabIndex = 34;
            this.grbBoxCustomersMovements.TabStop = false;
            this.grbBoxCustomersMovements.Text = "حركات العملاء";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(28, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "إلغاء";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(28, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "حفظ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(260, 31);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "رقم العميل : ";
            // 
            // lblCustomerPhoneNumber
            // 
            this.lblCustomerPhoneNumber.AutoSize = true;
            this.lblCustomerPhoneNumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustomerPhoneNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCustomerPhoneNumber.Location = new System.Drawing.Point(169, 31);
            this.lblCustomerPhoneNumber.Name = "lblCustomerPhoneNumber";
            this.lblCustomerPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCustomerPhoneNumber.Size = new System.Drawing.Size(63, 15);
            this.lblCustomerPhoneNumber.TabIndex = 17;
            this.lblCustomerPhoneNumber.Text = "97754532";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(254, 65);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "أسم العميل : ";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustomerName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCustomerName.Location = new System.Drawing.Point(93, 61);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCustomerName.Size = new System.Drawing.Size(141, 15);
            this.lblCustomerName.TabIndex = 18;
            this.lblCustomerName.Text = "محمود احمد حامد عبدالحميد";
            // 
            // btnReceivedVoucher
            // 
            this.btnReceivedVoucher.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReceivedVoucher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReceivedVoucher.Location = new System.Drawing.Point(61, 243);
            this.btnReceivedVoucher.Name = "btnReceivedVoucher";
            this.btnReceivedVoucher.Size = new System.Drawing.Size(221, 32);
            this.btnReceivedVoucher.TabIndex = 23;
            this.btnReceivedVoucher.Text = "سندات القبض";
            this.btnReceivedVoucher.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReports.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReports.Location = new System.Drawing.Point(61, 295);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(221, 32);
            this.btnReports.TabIndex = 22;
            this.btnReports.Text = "التقارير";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnReturnInvoices
            // 
            this.btnReturnInvoices.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReturnInvoices.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReturnInvoices.Location = new System.Drawing.Point(61, 191);
            this.btnReturnInvoices.Name = "btnReturnInvoices";
            this.btnReturnInvoices.Size = new System.Drawing.Size(221, 32);
            this.btnReturnInvoices.TabIndex = 21;
            this.btnReturnInvoices.Text = "فواتير مرجع البيع";
            this.btnReturnInvoices.UseVisualStyleBackColor = false;
            // 
            // btnSalesInvoices
            // 
            this.btnSalesInvoices.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSalesInvoices.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSalesInvoices.Location = new System.Drawing.Point(61, 139);
            this.btnSalesInvoices.Name = "btnSalesInvoices";
            this.btnSalesInvoices.Size = new System.Drawing.Size(221, 32);
            this.btnSalesInvoices.TabIndex = 20;
            this.btnSalesInvoices.Text = "فواتير البيع";
            this.btnSalesInvoices.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.Location = new System.Drawing.Point(61, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 32);
            this.button3.TabIndex = 27;
            this.button3.Text = "الغاء";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnReturnPurchacesInvoice
            // 
            this.btnReturnPurchacesInvoice.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReturnPurchacesInvoice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReturnPurchacesInvoice.Location = new System.Drawing.Point(61, 407);
            this.btnReturnPurchacesInvoice.Name = "btnReturnPurchacesInvoice";
            this.btnReturnPurchacesInvoice.Size = new System.Drawing.Size(221, 32);
            this.btnReturnPurchacesInvoice.TabIndex = 26;
            this.btnReturnPurchacesInvoice.Text = "فواتير مرجع الشراء";
            this.btnReturnPurchacesInvoice.UseVisualStyleBackColor = false;
            // 
            // btnPurchecesInvoices
            // 
            this.btnPurchecesInvoices.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPurchecesInvoices.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPurchecesInvoices.Location = new System.Drawing.Point(61, 355);
            this.btnPurchecesInvoices.Name = "btnPurchecesInvoices";
            this.btnPurchecesInvoices.Size = new System.Drawing.Size(221, 32);
            this.btnPurchecesInvoices.TabIndex = 25;
            this.btnPurchecesInvoices.Text = "فواتير الشراء";
            this.btnPurchecesInvoices.UseVisualStyleBackColor = false;
            // 
            // btnPaymentVoucher
            // 
            this.btnPaymentVoucher.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPaymentVoucher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPaymentVoucher.Location = new System.Drawing.Point(61, 459);
            this.btnPaymentVoucher.Name = "btnPaymentVoucher";
            this.btnPaymentVoucher.Size = new System.Drawing.Size(221, 32);
            this.btnPaymentVoucher.TabIndex = 24;
            this.btnPaymentVoucher.Text = "سندات الصرف";
            this.btnPaymentVoucher.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(38, 90);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(267, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "-----------------------------------------------------------------";
            // 
            // ctrlCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbBoxCustomersMovements);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbBoxAddEditCustomer);
            this.Name = "ctrlCustomers";
            this.Size = new System.Drawing.Size(1116, 815);
            this.Load += new System.EventHandler(this.ctrlCustomers_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCustomers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesManagmentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.grbBoxAddEditCustomer.ResumeLayout(false);
            this.grbBoxAddEditCustomer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbBoxCustomersMovements.ResumeLayout(false);
            this.grbBoxCustomersMovements.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearchCustomers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvAllCustomers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem إستمرارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إضافةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إلغاءToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الحركاتToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private SalesManagmentDBDataSet salesManagmentDBDataSet;
        private SalesManagmentDBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.GroupBox grbBoxAddEditCustomer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHouseNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGadaNumber;
        private System.Windows.Forms.TextBox txtStreetNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBlockNaumber;
        private System.Windows.Forms.TextBox txtAreaName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerPhoneNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grbBoxCustomersMovements;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCustomerPhoneNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnReceivedVoucher;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnReturnInvoices;
        private System.Windows.Forms.Button btnSalesInvoices;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnReturnPurchacesInvoice;
        private System.Windows.Forms.Button btnPurchecesInvoices;
        private System.Windows.Forms.Button btnPaymentVoucher;
    }
}
