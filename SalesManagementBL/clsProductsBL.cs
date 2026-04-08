using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesManagementApp.SalesManagementDAL;

namespace SalesManagementApp.SalesManagementBL
{
    internal class clsProductsBL
    {

        clsProductsDAL Products = new clsProductsDAL();

        public List<Product> GetAllProducts()
        {
            return Products.GetAllProducts();
        }


        public bool AddNewProduct(Product product)
        {
            return Products.AddNewProducts(product);
        }

        public bool DeleteProduct(int product)
        {
            return Products.DeleteProduct(product);
        }

        public bool UpdateProduct(Product product)
        {
            return Products.UpdateProduct(product);

        }


        public bool IsExist(int productId)
        {

            return Products.IsProductExist(productId);
        }

        public List<Product> SearchCustomers(string searchTerm)
        {
            return Products.SearchCustomers(searchTerm);
        }


    } 
}
