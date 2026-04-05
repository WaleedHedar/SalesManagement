using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementApp.SalesManagementDAL
{
    internal class clsSuppliersDAL
    {

        SalesManagmentDBEntities db = new SalesManagmentDBEntities();

        public List<Supplier> GetAllSuppliers()
        {
            return db.Suppliers.ToList();
        }


        public bool AddSupplier(Supplier supplier)
        {
            try
            {
                db.Suppliers.Add(supplier);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

           
        }


        public List<Supplier> SearchSupplier(string searchTerm)
        {
            return db.Suppliers.Where(c => c.SupplierName.Contains(searchTerm) || c.Phone.Contains(searchTerm)).ToList();
        }

        public bool UpdateSupplier(int SupplierID, string SupplierName, string Phone, string Address)
        {
            Supplier supplier = db.Suppliers.Find(SupplierID);

            try
            {
                if (supplier != null)
                {
                    supplier.SupplierName = SupplierName;
                    supplier.Phone = Phone;
                    supplier.Address = Address;
                  
                    db.SaveChanges();
                }
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public bool DeleteSupplier(int SupplierID)
        {
            var Supplier = db.Suppliers.Find(SupplierID);
            try
            {
                if (Supplier != null)
                {
                    db.Suppliers.Remove(Supplier);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }



        }

        public Supplier GetSupplierByID(int SupplierID)
        {
           
            Supplier supplier = db.Suppliers.Find(SupplierID);

            if (supplier != null)
                return supplier;

            else
                return null;

        }

        public bool FindsupplierByPhone(string phone)
        {
            var supplier = db.Suppliers.FirstOrDefault(c => c.Phone == phone);

            if (supplier != null)
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
