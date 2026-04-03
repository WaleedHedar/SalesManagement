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

namespace SalesManagementApp.SalesMamagementPL
{
    public partial class FrmCustomersMovement : Form
    {
        private int _customerID;    
        public FrmCustomersMovement(int CustomerID)
        {
            InitializeComponent();

            _customerID = CustomerID;  
        }


        private void FrmCustomersMovement_Load(object sender, EventArgs e)
        {
            cmbSearchCustomers.SelectedIndex = 1;

            Customer customer = new clsCustomerBL().GetCustomerByIdBL(_customerID);

            if (customer != null)
            {
                lblCustomerName.Text = customer.CustomerName;
                lblCustomerPhoneNumber.Text = customer.Phone;
                txtSearch.Text = customer.CustomerName;
                txtSearch.ReadOnly = true;
                lblCustomerName2.Text = customer.CustomerName;
                lblCustomerPhoneNumber2.Text = customer.Phone;

            }
            else
                return;


        }
    }
}
