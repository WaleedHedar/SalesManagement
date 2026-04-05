using SalesManagementApp.SalesManagementBL;
using SalesManagementApp.SalesManagementDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementApp.SalesMamagementPL
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }
        
        clsCustomerBL Customer1 = new clsCustomerBL();

        private void SetupDataGridView()
        {
            dgvAllCustomers.AllowUserToAddRows = false;
            dgvAllCustomers.ReadOnly = true;
            dgvAllCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllCustomers.MultiSelect = false;
            dgvAllCustomers.RowHeadersVisible = false;

            dgvAllCustomers.BorderStyle = BorderStyle.None;
            dgvAllCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvAllCustomers.EnableHeadersVisualStyles = false;
            dgvAllCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvAllCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAllCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 12, FontStyle.Bold);

            dgvAllCustomers.DefaultCellStyle.BackColor = Color.White;
            dgvAllCustomers.DefaultCellStyle.ForeColor = Color.Black;
            dgvAllCustomers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvAllCustomers.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvAllCustomers.DefaultCellStyle.Font = new Font("Calibri", 12);
            dgvAllCustomers.RowTemplate.Height = 33;
            dgvAllCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            dgvAllCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
            clsCustomerBL clscustomerbL = new clsCustomerBL();

            dgvAllCustomers.DataSource = clscustomerbL.GetAllCustomersBL();

            // add Seq column if it doesn't exist
            if (!dgvAllCustomers.Columns.Contains("Seq"))
            {
                dgvAllCustomers.Columns.Insert(0, new DataGridViewTextBoxColumn
                {
                    Name = "Seq",
                    HeaderText = "م",
                    Width = 56,
                    ReadOnly = true
                });
            }

            for (int i = 0; i < dgvAllCustomers.Rows.Count; i++)
            {
                dgvAllCustomers.Rows[i].Cells["Seq"].Value = i + 1;
            }
        }

        private void RefereshDataGridView()
        {
            
            clsCustomerBL clscustomerbL = new clsCustomerBL();

            dgvAllCustomers.DataSource = clscustomerbL.GetAllCustomersBL();

            
            for (int i = 0; i < dgvAllCustomers.Rows.Count; i++)
            {
                dgvAllCustomers.Rows[i].Cells["Seq"].Value = i + 1;
            }

            txtSearch.Focus();


        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            cmbSearchCustomers.SelectedIndex = 0;
            SetupDataGridView();        

        }

        private int GetSelectedCustomerID()
        {
            if (dgvAllCustomers.SelectedRows.Count > 0)
            {
                var row = dgvAllCustomers.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[row.DataGridView.Columns["CustomerID"].Index].Value);
                return id;  
            }

            return 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddUdateCustomers frmAddUdateCustomers = new FrmAddUdateCustomers(0);
            frmAddUdateCustomers.ShowDialog();
            RefereshDataGridView();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if(GetSelectedCustomerID() !=0)
            {
                FrmAddUdateCustomers frmAddUdateCustomers = new FrmAddUdateCustomers(GetSelectedCustomerID());
                frmAddUdateCustomers.ShowDialog();
                RefereshDataGridView();
            }
            else
                {
                MessageBox.Show("من فضلك اختر عميل للتعديل عليه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int customerId = GetSelectedCustomerID();

            if (Customer1.DeleteCustomerBL(customerId))
            {
                MessageBox.Show("تم حذف العميل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefereshDataGridView();

            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء حذف العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMovement_Click(object sender, EventArgs e)
        {
            int customerId = GetSelectedCustomerID();

            if (GetSelectedCustomerID() != 0)
            {
                FrmCustomersMovement frmCustomersMovement = new FrmCustomersMovement(customerId);
                frmCustomersMovement.ShowDialog();

            }
            else
                return;
           
        }
    }
}
