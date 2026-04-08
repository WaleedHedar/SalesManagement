namespace SalesManagementApp.SalesMamagementPL
{
    partial class FrmMainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddSalesInvoice = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnGetAllSalesInvoices = new System.Windows.Forms.Button();
            this.btnSupplyerAccount = new System.Windows.Forms.Button();
            this.btnAddPurchesesInvoice = new System.Windows.Forms.Button();
            this.btnCustomerAccount = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnGetAllPurchesesInvoices = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnReceiptVoucher = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnPaymentVoucher = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAddSalesInvoice);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.btnGetAllSalesInvoices);
            this.panel1.Controls.Add(this.btnSupplyerAccount);
            this.panel1.Controls.Add(this.btnAddPurchesesInvoice);
            this.panel1.Controls.Add(this.btnCustomerAccount);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnGetAllPurchesesInvoices);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.btnReceiptVoucher);
            this.panel1.Controls.Add(this.btnSuppliers);
            this.panel1.Controls.Add(this.btnPaymentVoucher);
            this.panel1.Location = new System.Drawing.Point(1138, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 815);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(28, 678);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 37);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAddSalesInvoice
            // 
            this.btnAddSalesInvoice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddSalesInvoice.Location = new System.Drawing.Point(28, 19);
            this.btnAddSalesInvoice.Name = "btnAddSalesInvoice";
            this.btnAddSalesInvoice.Size = new System.Drawing.Size(212, 37);
            this.btnAddSalesInvoice.TabIndex = 0;
            this.btnAddSalesInvoice.Text = "إصدار فاتورة بيع";
            this.btnAddSalesInvoice.UseVisualStyleBackColor = true;
            this.btnAddSalesInvoice.Click += new System.EventHandler(this.btnAddSalesInvoice_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Navy;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(71, 774);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(133, 32);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "اسم المستخدم";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // btnGetAllSalesInvoices
            // 
            this.btnGetAllSalesInvoices.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGetAllSalesInvoices.Location = new System.Drawing.Point(28, 72);
            this.btnGetAllSalesInvoices.Name = "btnGetAllSalesInvoices";
            this.btnGetAllSalesInvoices.Size = new System.Drawing.Size(212, 37);
            this.btnGetAllSalesInvoices.TabIndex = 1;
            this.btnGetAllSalesInvoices.Text = "مراجعة فواتير البيع";
            this.btnGetAllSalesInvoices.UseVisualStyleBackColor = true;
            this.btnGetAllSalesInvoices.Click += new System.EventHandler(this.btnGetAllSalesInvoices_Click);
            // 
            // btnSupplyerAccount
            // 
            this.btnSupplyerAccount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSupplyerAccount.Location = new System.Drawing.Point(28, 573);
            this.btnSupplyerAccount.Name = "btnSupplyerAccount";
            this.btnSupplyerAccount.Size = new System.Drawing.Size(212, 37);
            this.btnSupplyerAccount.TabIndex = 11;
            this.btnSupplyerAccount.Text = "كشف حساب مورد";
            this.btnSupplyerAccount.UseVisualStyleBackColor = true;
            this.btnSupplyerAccount.Click += new System.EventHandler(this.btnSupplyerAccount_Click);
            // 
            // btnAddPurchesesInvoice
            // 
            this.btnAddPurchesesInvoice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddPurchesesInvoice.Location = new System.Drawing.Point(28, 129);
            this.btnAddPurchesesInvoice.Name = "btnAddPurchesesInvoice";
            this.btnAddPurchesesInvoice.Size = new System.Drawing.Size(212, 37);
            this.btnAddPurchesesInvoice.TabIndex = 5;
            this.btnAddPurchesesInvoice.Text = "إصدار فاتورة الشراء";
            this.btnAddPurchesesInvoice.UseVisualStyleBackColor = true;
            this.btnAddPurchesesInvoice.Click += new System.EventHandler(this.btnAddPurchesesInvoice_Click);
            // 
            // btnCustomerAccount
            // 
            this.btnCustomerAccount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCustomerAccount.Location = new System.Drawing.Point(28, 518);
            this.btnCustomerAccount.Name = "btnCustomerAccount";
            this.btnCustomerAccount.Size = new System.Drawing.Size(212, 37);
            this.btnCustomerAccount.TabIndex = 10;
            this.btnCustomerAccount.Text = "كشف حساب عميل";
            this.btnCustomerAccount.UseVisualStyleBackColor = true;
            this.btnCustomerAccount.Click += new System.EventHandler(this.btnCustomerAccount_Click);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReports.Location = new System.Drawing.Point(28, 626);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(212, 37);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "التقارير";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnGetAllPurchesesInvoices
            // 
            this.btnGetAllPurchesesInvoices.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGetAllPurchesesInvoices.Location = new System.Drawing.Point(28, 184);
            this.btnGetAllPurchesesInvoices.Name = "btnGetAllPurchesesInvoices";
            this.btnGetAllPurchesesInvoices.Size = new System.Drawing.Size(212, 37);
            this.btnGetAllPurchesesInvoices.TabIndex = 6;
            this.btnGetAllPurchesesInvoices.Text = "مراجعة فواتير الشراء";
            this.btnGetAllPurchesesInvoices.UseVisualStyleBackColor = true;
            this.btnGetAllPurchesesInvoices.Click += new System.EventHandler(this.btnGetAllPurchesesInvoices_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Cyan;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomers.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCustomers.Location = new System.Drawing.Point(28, 240);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(212, 37);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "إدارة العملاء";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Lime;
            this.btnProducts.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnProducts.Location = new System.Drawing.Point(28, 464);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(212, 37);
            this.btnProducts.TabIndex = 4;
            this.btnProducts.Text = "فهرس الأصناف";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnReceiptVoucher
            // 
            this.btnReceiptVoucher.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReceiptVoucher.Location = new System.Drawing.Point(28, 409);
            this.btnReceiptVoucher.Name = "btnReceiptVoucher";
            this.btnReceiptVoucher.Size = new System.Drawing.Size(212, 37);
            this.btnReceiptVoucher.TabIndex = 8;
            this.btnReceiptVoucher.Text = "سندات القبض";
            this.btnReceiptVoucher.UseVisualStyleBackColor = true;
            this.btnReceiptVoucher.Click += new System.EventHandler(this.btnReceiptVoucher_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.Cyan;
            this.btnSuppliers.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSuppliers.Location = new System.Drawing.Point(28, 295);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(212, 37);
            this.btnSuppliers.TabIndex = 7;
            this.btnSuppliers.Text = "إدارة الموردين";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnPaymentVoucher
            // 
            this.btnPaymentVoucher.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPaymentVoucher.Location = new System.Drawing.Point(28, 354);
            this.btnPaymentVoucher.Name = "btnPaymentVoucher";
            this.btnPaymentVoucher.Size = new System.Drawing.Size(212, 37);
            this.btnPaymentVoucher.TabIndex = 3;
            this.btnPaymentVoucher.Text = "سندات الصرف";
            this.btnPaymentVoucher.UseVisualStyleBackColor = true;
            this.btnPaymentVoucher.Click += new System.EventHandler(this.btnPaymentVoucher_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1116, 815);
            this.MainPanel.TabIndex = 2;
            // 
            // FrmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1404, 839);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.MaximizeBox = false;
            this.Name = "FrmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الصفحة الرئيسية";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainForm_FormClosing);
            this.Load += new System.EventHandler(this.FrmMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnAddSalesInvoice;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnReceiptVoucher;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnGetAllPurchesesInvoices;
        private System.Windows.Forms.Button btnAddPurchesesInvoice;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnPaymentVoucher;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnGetAllSalesInvoices;
        private System.Windows.Forms.Button btnSupplyerAccount;
        private System.Windows.Forms.Button btnCustomerAccount;
        private System.Windows.Forms.Button button1;
    }
}