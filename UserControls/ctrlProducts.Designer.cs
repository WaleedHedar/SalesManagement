namespace SalesManagementApp.UserControls
{
    partial class ctrlIProducts
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
            this.grbBoxSuppliers = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMovementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAllProducts = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.salesManagmentDBDataSet2 = new SalesManagementApp.SalesManagmentDBDataSet2();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new SalesManagementApp.SalesManagmentDBDataSet2TableAdapters.ProductsTableAdapter();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbBoxSuppliers.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesManagmentDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbBoxSuppliers
            // 
            this.grbBoxSuppliers.BackColor = System.Drawing.SystemColors.Control;
            this.grbBoxSuppliers.Controls.Add(this.panel2);
            this.grbBoxSuppliers.Controls.Add(this.dgvAllProducts);
            this.grbBoxSuppliers.Controls.Add(this.panel3);
            this.grbBoxSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbBoxSuppliers.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grbBoxSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbBoxSuppliers.Location = new System.Drawing.Point(22, 32);
            this.grbBoxSuppliers.Name = "grbBoxSuppliers";
            this.grbBoxSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbBoxSuppliers.Size = new System.Drawing.Size(1066, 768);
            this.grbBoxSuppliers.TabIndex = 38;
            this.grbBoxSuppliers.TabStop = false;
            this.grbBoxSuppliers.Text = "إدارة الأصناف";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(442, 696);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(568, 33);
            this.panel2.TabIndex = 39;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddToolStripMenuItem,
            this.btnEditToolStripMenuItem,
            this.btnDeleteToolStripMenuItem,
            this.btnMovementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAddToolStripMenuItem
            // 
            this.btnAddToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddToolStripMenuItem.Name = "btnAddToolStripMenuItem";
            this.btnAddToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.btnAddToolStripMenuItem.Text = "إضافة";
            // 
            // btnEditToolStripMenuItem
            // 
            this.btnEditToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditToolStripMenuItem.Name = "btnEditToolStripMenuItem";
            this.btnEditToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.btnEditToolStripMenuItem.Text = "تعديل";
            // 
            // btnDeleteToolStripMenuItem
            // 
            this.btnDeleteToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDeleteToolStripMenuItem.Name = "btnDeleteToolStripMenuItem";
            this.btnDeleteToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.btnDeleteToolStripMenuItem.Text = "حذف";
            // 
            // btnMovementToolStripMenuItem
            // 
            this.btnMovementToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMovementToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMovementToolStripMenuItem.Name = "btnMovementToolStripMenuItem";
            this.btnMovementToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.btnMovementToolStripMenuItem.Text = "الحركات";
            // 
            // dgvAllProducts
            // 
            this.dgvAllProducts.AutoGenerateColumns = false;
            this.dgvAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.CategoryID,
            this.Price,
            this.Quantity});
            this.dgvAllProducts.DataSource = this.productsBindingSource;
            this.dgvAllProducts.Location = new System.Drawing.Point(39, 91);
            this.dgvAllProducts.Name = "dgvAllProducts";
            this.dgvAllProducts.Size = new System.Drawing.Size(971, 582);
            this.dgvAllProducts.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(436, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 37);
            this.panel3.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(502, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 19);
            this.label13.TabIndex = 17;
            this.label13.Text = "البحــــــــــث";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(12, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(484, 27);
            this.txtSearch.TabIndex = 0;
            // 
            // salesManagmentDBDataSet2
            // 
            this.salesManagmentDBDataSet2.DataSetName = "SalesManagmentDBDataSet2";
            this.salesManagmentDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.salesManagmentDBDataSet2;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "رقم الصنف";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "أسم الصنف";
            this.ProductName.Name = "ProductName";
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "رقم الفئة";
            this.CategoryID.Name = "CategoryID";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "السعر";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "الكمية";
            this.Quantity.Name = "Quantity";
            // 
            // ctrlIProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbBoxSuppliers);
            this.Name = "ctrlIProducts";
            this.Size = new System.Drawing.Size(1116, 815);
            this.grbBoxSuppliers.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesManagmentDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBoxSuppliers;
        private System.Windows.Forms.DataGridView dgvAllProducts;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMovementToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private SalesManagmentDBDataSet2 salesManagmentDBDataSet2;
        private SalesManagmentDBDataSet2TableAdapters.ProductsTableAdapter productsTableAdapter;
    }
}
