using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceDemo
{
    public class ProductService : IProductService
    {
        public static List<Product> products = new List<Product>()
         {
                new Product { Id = 1, Name = "AGUA", Price = 1.50f },
                new Product { Id = 2, Name = "CAFE", Price = 2.80f },
                new Product { Id = 3, Name = "LECHE", Price = 3.90f }
         };

        public bool AddProduct(string name)
        {
            return true;
        }

        public bool UpdateProduct(string id, string name)
        {
            return true;
        }


        public bool DeleteProduct(string id)
        {
            return true;
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(string id)
        {
            var product = products.Where(p => p.Id == Convert.ToInt32(id)).FirstOrDefault();
            return product;
        }

    }
}