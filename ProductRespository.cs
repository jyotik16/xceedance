using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBIZ
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Lenovo Laptop";
                product.ProductDescription = "Carbon X1";
                product.CurrentPrice = 1599.99M;
            }
            return product;
        }

        public bool Save()
        {
            return true;
        }

    }
}