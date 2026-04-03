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
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }


        


        private void CheckLogIn()
        {
            string userName = txtUserName.Text.Trim();
            string password = txtPassWord.Text.Trim();

            SalesManagmentDBEntities db = new SalesManagmentDBEntities();

            var IsExist = db.Users.Where(u => u.Username == userName && u.Password == password).FirstOrDefault();


            //dont forget the Permission of the user to open the main form and show the buttons that he has access to them
            

            if (IsExist!=null)
            {
                MessageBox.Show($"  ( لاتنسي الصلاحيات ) {userName} تم تسجيل الدخول بنجاح","تسجيل الدخول",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);

                clsCurrentUser._UserName = txtUserName.Text.Trim();
                this.Hide();
                FrmMainForm mainForm = new FrmMainForm();
                mainForm.ShowDialog();
                

            }
            else
            {
                MessageBox.Show("أسم المستخدم او كلمة المرور غير صحيحة", "تسجيل الدخول", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtUserName.Clear();
                txtPassWord.Clear();
                txtUserName.Focus();
            }

        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            CheckLogIn();
        }
    }
}
