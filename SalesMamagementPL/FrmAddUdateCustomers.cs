using SalesManagementApp.SalesManagementBL;
using SalesManagementApp.SalesManagementDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementApp.SalesMamagementPL
{
    public partial class FrmAddUdateCustomers : Form
    {
        private enum Mode { Add = 0, Update = 1 }

        private Mode _EnMode;
        private int _CustomerID;
        public FrmAddUdateCustomers(int Number)
        {
            InitializeComponent();

            if (Number == 0)
                _EnMode = Mode.Add;
            else if (Number == -1)
                return;
            else
                _CustomerID = Number;
                _EnMode = Mode.Update;
        }

        public struct stAddress
        {
            public string Area;
            public string Block;
            public string Street;
            public string gada;
            public string House;

        }

        clsCustomerBL Customer1 = new clsCustomerBL();

        private string GetFullAddress()
        {
            string area = txtAreaName.Text ;
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
                    this.Close();
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
                    this.Close();
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
            string Phone = txtCustomerPhoneNumber.Text  ;

            if(_EnMode == Mode.Update)
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

            }
            else
            {

                    btnSave.Enabled = true;
            }

        }


        private void FillDataToForm()
        {

            Customer customer = new Customer();
            customer = Customer1.GetCustomerByIdBL(_CustomerID);

            if (customer != null)
            {

                txtCustomerPhoneNumber.Text = customer.Phone;
                txtCustomerPhoneNumber.ReadOnly = true;

                txtCustomerName.Text = customer.CustomerName;

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

            btnSave.Enabled = true;

        }

        private void FrmAddUdateCustomers_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;

            if(_CustomerID > 0)
            {
                FillDataToForm();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCustomerNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtCustomerNumber_TextChanged(object sender, EventArgs e)
        {
            
            
            string numbersOnly = new string(txtCustomerPhoneNumber.Text.Where(char.IsDigit).ToArray());
            if (txtCustomerPhoneNumber.Text != numbersOnly)
            {
                int cursorPos = txtCustomerPhoneNumber.SelectionStart - 1;
                txtCustomerPhoneNumber.Text = numbersOnly;
                txtCustomerPhoneNumber.SelectionStart = Math.Max(cursorPos, 0);
            }
        }
    }
}
