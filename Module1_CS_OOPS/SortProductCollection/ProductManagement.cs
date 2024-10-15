using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProductCollection
{
    internal class ProductManagement
    {
        List<Product> products=null;

        public ProductManagement()
        {
            products = new List<Product>
            {
                new Product{ ProductId=1001,Description="Mi TV",BrandName="Android",Price=25000},
                new Product{ ProductId=1002,Description="Mouse",BrandName="Logitech",Price=150},
                new Product{ ProductId=1003,Description="Laptop",BrandName="Dell",Price=35000}
            };
        }
        public List<Product> GetProductsSortById()
        {
            products.Sort();
            return products;
        }
        public List<Product> GetProductsSortByBrandname()
        {
            products.Sort(new SortByBrandName());
            return products;
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
