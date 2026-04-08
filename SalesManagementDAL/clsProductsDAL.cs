using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementApp.SalesManagementDAL
{
    internal class clsProductsDAL
    {

        SalesManagmentDBEntities db = new SalesManagmentDBEntities();
        public List<Product> GetAllProducts()
        {
            return db.Products.ToList();    
        }

        public bool AddNewProducts(Product product)
        {
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }


        }


        public bool DeleteProduct(int ProductId)
        {
            var IsExist = db.Products.Find(ProductId);

            if (IsExist == null)
            {
                db.Products.Remove(IsExist);
                db.SaveChanges() ;
                return true;

            }
            else
                return false;

        }

        public bool UpdateProduct(Product product)
        {
            Product productToUpdate = db.Products.Find(product);

            if (productToUpdate != null)
            {
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.CategoryID = product.CategoryID;    
                productToUpdate.Price = product.Price;
                productToUpdate.Quantity = product.Quantity;
                db.SaveChanges();
                return true;
            }
            else
                { return false; }   


        }

        public bool IsProductExist(int ProductId)
        {
            return db.Products.Find(ProductId) != null;
        }


        public List<Product> SearchCustomers(string searchTerm)
        {
            return db.Products.Where(c => c.ProductName.Contains(searchTerm) || c.ProductID.ToString().Contains(searchTerm)).ToList();
        }


    }
}
