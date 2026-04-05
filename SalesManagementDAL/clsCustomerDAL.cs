using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementApp.SalesManagementDAL
{
    internal class clsCustomerDAL
    {

        SalesManagmentDBEntities db = new SalesManagmentDBEntities();

        public List<Customer> GetAllCustomers()
        {
            return db.Customers.ToList();
        }



        public bool AddCustomer(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                db.SaveChanges();
               
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

           
        }


        public List<Customer> SearchCustomers(string searchTerm)
        {
            return db.Customers.Where(c => c.CustomerName.Contains(searchTerm) || c.Phone.Contains(searchTerm)).ToList();
        }

        public bool UpdateCustomer(int CustomerID, string CustomerName, string Phone, string Address)
        {
            Customer customer = db.Customers.Find(CustomerID);

            try
            {
                if (customer != null)
                {
                    customer.CustomerName = CustomerName;
                    customer.Phone = Phone;
                    customer.Address = Address;
                    db.SaveChanges();
                }
                return true;

            }
            catch(Exception ex)
            {
                return false;
            }
           
        }


        public bool DeleteCustomer(int customerId)
        {
            var customer = db.Customers.Find(customerId);
            try
            {
                if (customer != null)
                {
                    db.Customers.Remove(customer);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


           
        }

        public Customer GetCustomerByID(int CustomerID)
        {
            Customer customer = db.Customers.Find(CustomerID);
            

            if (customer!=null)
                return customer;

            else
                return null;

        }

        public bool FindCustomerByPhone(string phone)
        {
            var customer = db.Customers.FirstOrDefault(c => c.Phone == phone);

            if (customer != null)
            {
                return true; // Customer found with the given phone number
            }
            else
            {
                return false; // No customer found with the given phone number
            }


        }
    }

}
