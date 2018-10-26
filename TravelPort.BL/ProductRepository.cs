using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPort.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            // instance of the Product class
            Product product = new Product(productId);

            // code that retrieves Product

            // temporary hard code for populating product
            if (productId == 2)
            {
                product.ProductName = "testProduct";
                product.ProductDescription = "testDesc";
                product.CurrentPrice = 14.44;
            }
            return product;
        }

        public bool Save()
        {
            // code that saves defined product
            return true;
        }
    }
}
