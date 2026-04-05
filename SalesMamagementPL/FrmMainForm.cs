using SalesManagementApp.UserControls;
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
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
        }

        public  string UserName = clsCurrentUser._UserName;

        private void FrmMainForm_Load(object sender, EventArgs e)
        {
            lblUserName.Text = UserName;
        }

        ctrlCustomers _ctrlCustomers = new ctrlCustomers();
        ctrlSuppliers _ctrlSuppliers = new ctrlSuppliers();


        private void LoadControl(UserControl ctrl)
        {
            MainPanel.Controls.Clear();   

            ctrl.Dock = DockStyle.Fill;  

            MainPanel.Controls.Add(ctrl); 
        }

        private void ActionNotEmplentedYet()
        {
            MessageBox.Show("This action not emplemented Yet. :) ");
        }

        private void btnAddSalesInvoice_Click(object sender, EventArgs e)
        {
            ActionNotEmplentedYet();
        }

        private void btnAddPurchesesInvoice_Click(object sender, EventArgs e)
        {
            ActionNotEmplentedYet();           
        }

        private void btnGetAllSalesInvoices_Click(object sender, EventArgs e)
        {
            ActionNotEmplentedYet();
        }

        private void btnGetAllPurchesesInvoices_Click(object sender, EventArgs e)
        {
            ActionNotEmplentedYet();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            LoadControl(_ctrlCustomers);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            LoadControl(_ctrlSuppliers);
        }

        private void btnPaymentVoucher_Click(object sender, EventArgs e)
        {
            ActionNotEmplentedYet();
        }

        private void btnReceiptVoucher_Click(object sender, EventArgs e)
        {
            ActionNotEmplentedYet();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActionNotEmplentedYet();
        }

        private void btnCustomerAccount_Click(object sender, EventArgs e)
        {
            ActionNotEmplentedYet();
        }

        private void btnSupplyerAccount_Click(object sender, EventArgs e)
        {
            ActionNotEmplentedYet();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            ActionNotEmplentedYet();
        }

        private void FrmMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {


            DialogResult result = MessageBox.Show(
                "هل تريد إغلاق البرنامج؟",
                "تأكيد",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true; // 
            }
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
            this.Hide();

            // this to hide the main form while the login form is open, and show it again if the login is successful.
            FrmLogIn login = new FrmLogIn();

            // this as model dialog to prevent the user from interacting with the main form while the login form is open, and to get the result of the login form.
            if (login.ShowDialog() == DialogResult.OK)
            {
                // if the login is successful → we show the main form again.
                this.Show();
            }
            else
            {
                //if the login is not successful → we close the main form.
                Application.Exit();
            }
        }
    }
}
