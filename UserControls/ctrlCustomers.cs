using SalesManagementApp.SalesMamagementPL;
using SalesManagementApp.SalesManagementBL;
using SalesManagementApp.SalesManagementDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementApp.UserControls
{
    public partial class ctrlCustomers : UserControl
    {
        public ctrlCustomers()
        {
            InitializeComponent();
        }


        private enum Mode { Add = 0, Update = 1 }

        private Mode _EnMode;
        private int _CustomerID;

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
            dgvAllCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Bold);

            dgvAllCustomers.DefaultCellStyle.BackColor = Color.White;
            dgvAllCustomers.DefaultCellStyle.ForeColor = Color.Black;
            dgvAllCustomers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvAllCustomers.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvAllCustomers.DefaultCellStyle.Font = new Font("Calibri", 10);
            dgvAllCustomers.RowTemplate.Height = 33;
            dgvAllCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            dgvAllCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            clsCustomerBL clscustomerbL = new clsCustomerBL();

            dgvAllCustomers.DataSource = clscustomerbL.GetAllCustomersBL();

            // add Seq column if it doesn't exist
            if (!dgvAllCustomers.Columns.Contains("Seq"))
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

                dgvAllCustomers.Columns.Insert(0, col);
            }

            for (int i = 0; i < dgvAllCustomers.Rows.Count; i++)
            {
                dgvAllCustomers.Rows[i].Cells["Seq"].Value = i + 1;
            }
        }

        private void dgvAllCustomers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvAllCustomers.Rows[e.RowIndex].Cells["Seq"].Value = (e.RowIndex + 1).ToString();
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

        private void ctrlCustomers_Load(object sender, EventArgs e)
        {
            
            SetupDataGridView();
            dgvAllCustomers.RowPostPaint += dgvAllCustomers_RowPostPaint;
            grbBoxAddEditCustomer.Enabled = false;
            grbBoxCustomersMovements.Enabled = false;
            lblCustomerName.Text = "";
            lblCustomerPhoneNumber.Text= "";

        }

        private void btnAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _EnMode = Mode.Add;
            grbBoxAddEditCustomer.Enabled = true;

        }

        public struct stAddress
        {
            public string Area;
            public string Block;
            public string Street;
            public string gada;
            public string House;

        }

        private string GetFullAddress()
        {
            string area = txtAreaName.Text;
            string block = txtBlockNaumber.Text;
            string street = txtStreetNumber.Text;
            string gada = txtGadaNumber.Text;
            string house = txtHouseNumber.Text;

            string fullAddress = area + ", " + block + ", " + street + ", " + gada + ", " + house;

            return fullAddress;
        }

        private bool AddNewCustomer()
        {
            // this from class that build by Entity Frame Work to safe the parameters .
            Customer Cust = new Customer();

            Cust.CustomerName = txtCustomerName.Text.Trim();
            Cust.Phone = txtCustomerPhoneNumber.Text.Trim();
            Cust.Address = GetFullAddress();

            return Customer1.AddCustomerBL(Cust);


        }

        private bool UpdateCustomer()
        {
            // this from class that build by Entity Frame Work to safe the parameters .
            string CustomerName = txtCustomerName.Text;
            string Phone = txtCustomerPhoneNumber.Text;
            string Address = GetFullAddress();

            return Customer1.UpdateCustomerBL(_CustomerID, CustomerName, Phone, Address);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_EnMode == Mode.Add)
            {
                if (AddNewCustomer())
                {
                    MessageBox.Show("تمت إضافة العميل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _EnMode = Mode.Update;
                    txtCustomerPhoneNumber.Clear();
                    txtCustomerName.Clear();
                    txtAreaName.Clear();
                    txtBlockNaumber.Clear();
                    txtStreetNumber.Clear();
                    txtGadaNumber.Clear();
                    txtHouseNumber.Clear();
                    RefereshDataGridView();
                    grbBoxAddEditCustomer.Enabled = false;

                }
                else
                {
                    MessageBox.Show("حدث خطأ أثناء إضافة العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (UpdateCustomer())
                {
                    MessageBox.Show("تم تحديث بيانات العميل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustomerPhoneNumber.Clear();
                    txtCustomerName.Clear();
                    txtAreaName.Clear();
                    txtBlockNaumber.Clear();
                    txtStreetNumber.Clear();
                    txtGadaNumber.Clear();
                    txtHouseNumber.Clear();
                    RefereshDataGridView();
                    grbBoxAddEditCustomer.Enabled = false;

                }
                else
                {
                    MessageBox.Show("حدث خطأ أثناء تحديث بيانات العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private bool CheckIsPhoneNumberUsedBefore(string PhoneNumber)
        {

            return Customer1.IsPhoneNumberUsedBefore(PhoneNumber);

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            string Phone = txtCustomerPhoneNumber.Text;

            if (_EnMode == Mode.Update)
            {
                return;
            }


            if (string.IsNullOrWhiteSpace(txtCustomerPhoneNumber.Text))
            {
                MessageBox.Show("يرجى إضافة رقم العميل أولا ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Enabled = false;
                txtCustomerPhoneNumber.Focus();
                txtCustomerName.Clear();

            }
            else if (CheckIsPhoneNumberUsedBefore(Phone))
            {
                MessageBox.Show("رقم الهاتف هذا مستخدم من قبل يرجى إدخال رقم هاتف آخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Enabled = false;
                txtCustomerPhoneNumber.Focus();
                txtCustomerName.Clear();
                return;

            }
            else
            {

                btnSave.Enabled = true;
            }

        }

        private void FillDataToGrbBoxAddEdit(int CustomerID)
        {

            Customer customer = new Customer();
            customer = Customer1.GetCustomerByIdBL(CustomerID);

            if (customer != null)
            {

                txtCustomerPhoneNumber.Text = customer.Phone;
                txtCustomerPhoneNumber.ReadOnly = true;

                txtCustomerName.Text = customer.CustomerName;

                lblCustomerPhoneNumber.Text = customer.Phone;
                lblCustomerName.Text = customer.CustomerName;

                if (customer.Address != null)
                {
                    string[] Address = customer.Address.Split(',')
                                    .Select(s => s.Trim())
                                    .ToArray();

                    //this struct to handle the address. 
                    stAddress Address1 = new stAddress
                    {
                        Area = Address.Length > 0 ? Address[0] : "",
                        Block = Address.Length > 1 ? Address[1] : "",
                        Street = Address.Length > 2 ? Address[2] : "",
                        gada = Address.Length > 3 ? Address[3] : "",
                        House = Address.Length > 4 ? Address[4] : ""
                    };




                    txtAreaName.Text = Address1.Area;
                    txtBlockNaumber.Text = Address1.Block;
                    txtStreetNumber.Text = Address1.Street;
                    txtGadaNumber.Text = Address1.gada;
                    txtHouseNumber.Text = Address1.House;

                }
                else
                {
                    txtAreaName.Text = "";
                    txtBlockNaumber.Text = "";
                    txtStreetNumber.Text = "";
                    txtGadaNumber.Text = "";
                    txtHouseNumber.Text = "";
                }

                txtNotes.Text = "";
            }

          

        }

        private void txtCustomerNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void btnEditToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _CustomerID = GetSelectedCustomerID();

            DialogResult result = MessageBox.Show(
                                        "هل تريد تعديل بيانات العميل؟",
                                             "تأكيد ",
                                   MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning);


            if (result == DialogResult.No)
            {
                return;
            }

            if (GetSelectedCustomerID() != 0)
            {
                _EnMode = Mode.Update;
                grbBoxAddEditCustomer.Enabled = true;
                FillDataToGrbBoxAddEdit(_CustomerID);

            }
            else
            {
                MessageBox.Show("من فضلك اختر عميل للتعديل عليه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAllCustomers.DataSource = Customer1.SearchCustomersBL(txtSearch.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCustomerPhoneNumber.Clear();
            txtCustomerName.Clear();
            txtAreaName.Clear();
            txtBlockNaumber.Clear();
            txtStreetNumber.Clear();
            txtGadaNumber.Clear();
            txtHouseNumber.Clear();
            RefereshDataGridView();
            grbBoxAddEditCustomer.Enabled = false;
        }

        private void btnDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CustomerID = GetSelectedCustomerID();

              DialogResult result = MessageBox.Show(
                                        "هل تريد حذف العميل؟",
                                             "تأكيد الحذف",
                                   MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning  );


             if(result == DialogResult.No)
             {
                return;
             }

            if (Customer1.DeleteCustomerBL(_CustomerID))
            {
                MessageBox.Show("تم حذف العميل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefereshDataGridView();

            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء حذف العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMovementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CustomerID = GetSelectedCustomerID();

            Customer customer = new Customer();
            customer = Customer1.GetCustomerByIdBL(_CustomerID);

            if (customer != null)
            {
                lblCustomerPhoneNumber.Text = customer.Phone;
                lblCustomerName.Text = customer.CustomerName;
                grbBoxCustomersMovements.Enabled = true;
            }
            else
            {
                MessageBox.Show("من فضلك اختر عميل لعرض حركاته", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            grbBoxCustomersMovements.Enabled = false;
            lblCustomerPhoneNumber.Text = "-------------";
            lblCustomerName.Text = "---------------------------";  
        }

      
      
    }

}
