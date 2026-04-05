using SalesManagementApp.SalesManagementDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementApp.SalesManagementBL
{
    internal class clsSupplierBL
    {
        clsSuppliersDAL SuppliersDAL = new clsSuppliersDAL();

        public List<Supplier> GetAllSuppliersBL()
        {
            return SuppliersDAL.GetAllSuppliers().ToList();
        }

        public List<Supplier> SearchSuppliersBL(string searchTerm)
        {
            return SuppliersDAL.SearchSupplier(searchTerm).ToList();
        }

        public bool AddSupplierBL(Supplier supplier)
        {
            return SuppliersDAL.AddSupplier(supplier);
        }

        public bool UpdateSupplierBL(int SupplierID, string SupplierName, string Phone, string Address)
        {
            return SuppliersDAL.UpdateSupplier(SupplierID, SupplierName, Phone, Address);
        }

        public bool DeleteSupplierBL(int supplierId)
        {
            return SuppliersDAL.DeleteSupplier(supplierId);
        }

        public Supplier GetSupplierByIdBL(int supplierId)
        {
            return SuppliersDAL.GetAllSuppliers().FirstOrDefault(s => s.SupplierID == supplierId);
        }

        public bool IsPhoneNumberUsedBefore(string phoneNumber)
        {
            return SuppliersDAL.GetAllSuppliers().Any(s => s.Phone == phoneNumber);
        }


        public bool IsSupplierNameUsedBefore(string supplierName)
        {
            return SuppliersDAL.GetAllSuppliers().Any(s => s.SupplierName == supplierName);
        }


        public bool IsSupplierNameUsedBeforeForOtherSupplier(string supplierName, int supplierId)
        {
            return SuppliersDAL.GetAllSuppliers().Any(s => s.SupplierName == supplierName && s.SupplierID != supplierId);
        }

        

    }
}
