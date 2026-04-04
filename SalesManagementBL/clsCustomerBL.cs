using SalesManagementApp.SalesManagementDAL;
using SalesManagementApp.SalesManagmentDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementApp.SalesManagementBL
{
    internal class clsCustomerBL
    {
        clsCustomerDAL clsCustomerDAL = new clsCustomerDAL();


        public List<Customer> GetAllCustomersBL()
        {
           return  clsCustomerDAL.GetAllCustomers().ToList();
        }



        public bool AddCustomerBL(Customer customer)
        {
            return clsCustomerDAL.AddCustomer(customer);
        }


        public bool UpdateCustomerBL(int CustomerID, string CustomerName, string Phone, string Address)
        {
            return clsCustomerDAL.UpdateCustomer(CustomerID, CustomerName, Phone, Address);
        }


        public bool DeleteCustomerBL(int customerId)
        {
           return  clsCustomerDAL.DeleteCustomer(customerId);
        }

        public Customer GetCustomerByIdBL(int customerId)
        {
            return clsCustomerDAL.GetCustomerByID(customerId);
        }

        public bool IsPhoneNumberUsedBefore(string phoneNumber)
        {
           return clsCustomerDAL.FindCustomerByPhone(phoneNumber);
        }

    }
}
