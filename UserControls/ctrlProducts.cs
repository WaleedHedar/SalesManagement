using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesManagementApp.SalesManagementBL;

namespace SalesManagementApp.UserControls
{
    public partial class ctrlIProducts : UserControl
    {
        public ctrlIProducts()
        {
            InitializeComponent();
        }


        clsProductsBL ProductsOBJ = new clsProductsBL();

        private void SetupDataGridView()
        {
            dgvAllProducts.AllowUserToAddRows = false;
            dgvAllProducts.ReadOnly = true;
            dgvAllProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllProducts.MultiSelect = false;
            dgvAllProducts.RowHeadersVisible = false;

            dgvAllProducts.BorderStyle = BorderStyle.None;
            dgvAllProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvAllProducts.EnableHeadersVisualStyles = false;
            dgvAllProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvAllProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAllProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Bold);

            dgvAllProducts.DefaultCellStyle.BackColor = Color.White;
            dgvAllProducts.DefaultCellStyle.ForeColor = Color.Black;
            dgvAllProducts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvAllProducts.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvAllProducts.DefaultCellStyle.Font = new Font("Calibri", 10);
            dgvAllProducts.RowTemplate.Height = 33;
            dgvAllProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            dgvAllProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;




            dgvAllProducts.DataSource = ProductsOBJ.GetAllProducts();

            // add Seq column if it doesn't exist
            if (!dgvAllProducts.Columns.Contains("Seq"))
            {
                var col = new DataGridViewTextBoxColumn
                {
                    Name = "Seq",
                    HeaderText = "م",
                    Width = 80,
                    ReadOnly = true,
                    Resizable = DataGridViewTriState.False,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                };

                dgvAllProducts.Columns.Insert(0, col);
            }

            for (int i = 0; i < dgvAllProducts.Rows.Count; i++)
            {
                dgvAllProducts.Rows[i].Cells["Seq"].Value = i + 1;
            }
        }

        private void dgvAllSuppliers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvAllProducts.Rows[e.RowIndex].Cells["Seq"].Value = (e.RowIndex + 1).ToString();
        }

        private void RefereshDataGridView()
        {



            dgvAllProducts.DataSource = ProductsOBJ.GetAllProducts();


            for (int i = 0; i < dgvAllProducts.Rows.Count; i++)
            {
                dgvAllProducts.Rows[i].Cells["Seq"].Value = i + 1;
            }

            txtSearch.Focus();


        }

        private int GetSelectedSupplierID()
        {
            if (dgvAllProducts.SelectedRows.Count > 0)
            {
                var row = dgvAllProducts.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[row.DataGridView.Columns["ProductID"].Index].Value);
                return id;
            }

            return 0;
        }


    }
}
