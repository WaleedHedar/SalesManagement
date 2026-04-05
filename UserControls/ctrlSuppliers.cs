using SalesManagementApp.SalesManagementBL;
using SalesManagementApp.SalesManagementDAL;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SalesManagementApp.UserControls
{
    public partial class ctrlSuppliers : UserControl
    {
        public ctrlSuppliers()
        {
            InitializeComponent();
        }


        private enum Mode { Add = 0, Update = 1 }

        private Mode _EnMode;
        private int _SupplierID;

       
        clsSuppliersDAL SuppliersOBJ = new clsSuppliersDAL();

        private void SetupDataGridView()
        {
            dgvAllSuppliers.AllowUserToAddRows = false;
            dgvAllSuppliers.ReadOnly = true;
            dgvAllSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllSuppliers.MultiSelect = false;
            dgvAllSuppliers.RowHeadersVisible = false;

            dgvAllSuppliers.BorderStyle = BorderStyle.None;
            dgvAllSuppliers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvAllSuppliers.EnableHeadersVisualStyles = false;
            dgvAllSuppliers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvAllSuppliers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAllSuppliers.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Bold);

            dgvAllSuppliers.DefaultCellStyle.BackColor = Color.White;
            dgvAllSuppliers.DefaultCellStyle.ForeColor = Color.Black;
            dgvAllSuppliers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvAllSuppliers.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvAllSuppliers.DefaultCellStyle.Font = new Font("Calibri", 10);
            dgvAllSuppliers.RowTemplate.Height = 33;
            dgvAllSuppliers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            dgvAllSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


           

            dgvAllSuppliers.DataSource = SuppliersOBJ.GetAllSuppliers();

            // add Seq column if it doesn't exist
            if (!dgvAllSuppliers.Columns.Contains("Seq"))
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

                dgvAllSuppliers.Columns.Insert(0, col);
            }

            for (int i = 0; i < dgvAllSuppliers.Rows.Count; i++)
            {
                dgvAllSuppliers.Rows[i].Cells["Seq"].Value = i + 1;
            }
        }

        private void dgvAllSuppliers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvAllSuppliers.Rows[e.RowIndex].Cells["Seq"].Value = (e.RowIndex + 1).ToString();
        }

        private void RefereshDataGridView()
        {

            

            dgvAllSuppliers.DataSource = SuppliersOBJ.GetAllSuppliers();


            for (int i = 0; i < dgvAllSuppliers.Rows.Count; i++)
            {
                dgvAllSuppliers.Rows[i].Cells["Seq"].Value = i + 1;
            }

            txtSearch.Focus();


        }

        private int GetSelectedSupplierID()
        {
            if (dgvAllSuppliers.SelectedRows.Count > 0)
            {
                var row = dgvAllSuppliers.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[row.DataGridView.Columns["SupplierIDdgv"].Index].Value);
                return id;
            }

            return 0;
        }

        private void ctrlSuppliers_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            dgvAllSuppliers.RowPostPaint += dgvAllSuppliers_RowPostPaint;
            grbBoxAddEditSuppliers.Enabled = false;
            grbBoxSupplierMovements.Enabled = false;
            lblSupplierName.Text = "";
            lblSupplierPhoneNumber.Text = "";
        }

        private void btnAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _EnMode = Mode.Add;
            grbBoxAddEditSuppliers.Enabled = true;

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

        private bool AddNewSupplier()
        {
            // this from class that build by Entity Frame Work to safe the parameters .
           
            Supplier Supp = new Supplier();
            Supp.SupplierName = txtSupplierName.Text.Trim();
            Supp.Phone = txtSupplierPhoneNumber.Text.Trim();
            Supp.Address = GetFullAddress();
           

            return SuppliersOBJ.AddSupplier(Supp);


        }

        private bool UpdateSupplier()
        {
            // this from class that build by Entity Frame Work to safe the parameters .
            string SupplierName = txtSupplierName.Text;
            string Phone = txtSupplierPhoneNumber.Text;
            string Address = GetFullAddress();

            return SuppliersOBJ.UpdateSupplier(_SupplierID, SupplierName, Phone, Address);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_EnMode == Mode.Add)
            {
                if (AddNewSupplier())
                {
                    MessageBox.Show("تمت إضافة المورد بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _EnMode = Mode.Update;
                    txtSupplierPhoneNumber.Clear();
                    txtSupplierName.Clear();
                    txtAreaName.Clear();
                    txtBlockNaumber.Clear();
                    txtStreetNumber.Clear();
                    txtGadaNumber.Clear();
                    txtHouseNumber.Clear();
                    RefereshDataGridView();
                    grbBoxAddEditSuppliers.Enabled = false;
                    

                }
                else
                {
                    MessageBox.Show("حدث خطأ أثناء إضافة المورد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (UpdateSupplier())
                {
                    MessageBox.Show("تم تحديث بيانات المورد بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSupplierPhoneNumber.Clear();
                    txtSupplierName.Clear();
                    txtAreaName.Clear();
                    txtBlockNaumber.Clear();
                    txtStreetNumber.Clear();
                    txtGadaNumber.Clear();
                    txtHouseNumber.Clear();
                    RefereshDataGridView();
                    grbBoxAddEditSuppliers.Enabled = false;

                }
                else
                {
                    MessageBox.Show("حدث خطأ أثناء تحديث بيانات المورد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private bool CheckIsPhoneNumberUsedBefore(string PhoneNumber)
        {

            return SuppliersOBJ.FindsupplierByPhone(PhoneNumber);

        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            string Phone = txtSupplierPhoneNumber.Text;

            if (_EnMode == Mode.Update)
            {
                return;
            }


            if (string.IsNullOrWhiteSpace(txtSupplierPhoneNumber.Text))
            {
                MessageBox.Show("يرجى إضافة رقم المورد أولا ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Enabled = false;
                txtSupplierPhoneNumber.Focus();
                txtSupplierName.Clear();

            }
            else if (CheckIsPhoneNumberUsedBefore(Phone))
            {
                MessageBox.Show("رقم الهاتف هذا مستخدم من قبل يرجى إدخال رقم هاتف آخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Enabled = false;
                txtSupplierPhoneNumber.Focus();
                txtSupplierName.Clear();

                return;

            }
            else
            {

                btnSave.Enabled = true;
            }

        }

        private void FillDataToGrbBoxAddEdit(int SupplierID)
        {

            
            Supplier supplier = new Supplier();
            supplier = SuppliersOBJ.GetSupplierByID(SupplierID);

            if (supplier != null)
            {

                txtSupplierPhoneNumber.Text = supplier.Phone;
                txtSupplierPhoneNumber.ReadOnly = true;

                txtSupplierName.Text = supplier.SupplierName;

                lblSupplierPhoneNumber.Text = supplier.Phone;
                lblSupplierName.Text = supplier.SupplierName;
                ;

                if (supplier.Address != null)
                {
                    string[] Address = supplier.Address.Split(',')
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

        private void txtSupplierNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void btnEditToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _SupplierID = GetSelectedSupplierID();

            DialogResult result = MessageBox.Show(
                                        "هل تريد تعديل بيانات المورد؟",
                                             "تأكيد ",
                                   MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning);


            if (result == DialogResult.No)
            {
                return;
            }

            if (GetSelectedSupplierID() != 0)
            {
                _EnMode = Mode.Update;
                grbBoxAddEditSuppliers.Enabled = true;
                FillDataToGrbBoxAddEdit(_SupplierID);

            }
            else
            {
                MessageBox.Show("من فضلك اختر مورد للتعديل عليه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAllSuppliers.DataSource = SuppliersOBJ.SearchSupplier(txtSearch.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSupplierPhoneNumber.Clear();
            txtSupplierName.Clear();
            txtAreaName.Clear();
            txtBlockNaumber.Clear();
            txtStreetNumber.Clear();
            txtGadaNumber.Clear();
            txtHouseNumber.Clear();
            RefereshDataGridView();
            grbBoxAddEditSuppliers.Enabled = false;
        }

        private void btnDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SupplierID = GetSelectedSupplierID();

            DialogResult result = MessageBox.Show(
                                      "هل تريد حذف المورد؟",
                                           "تأكيد الحذف",
                                 MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Warning);


            if (result == DialogResult.No)
            {
                return;
            }

            if (SuppliersOBJ.DeleteSupplier(_SupplierID ))
            {
                MessageBox.Show("تم حذف المورد بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefereshDataGridView();

            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء حذف المورد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMovementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SupplierID = GetSelectedSupplierID();

            Customer customer = new Customer();
            Supplier supplier = new Supplier();
           supplier = SuppliersOBJ.GetSupplierByID(_SupplierID);

            if (supplier != null)
            {
                lblSupplierPhoneNumber.Text = supplier.Phone;
                lblSupplierName.Text = supplier.SupplierName;
                grbBoxSupplierMovements.Enabled = true;
            }
            else
            {
                MessageBox.Show("من فضلك اختر مورد لعرض حركاته", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            grbBoxSupplierMovements.Enabled = false;
            lblSupplierPhoneNumber.Text = "-------------";
            lblSupplierName.Text = "---------------------------";
        }

       
    }

}
