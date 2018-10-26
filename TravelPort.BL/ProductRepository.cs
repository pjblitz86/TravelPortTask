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
                product.CurrentPrice = 14.44M;
            }
            return product;
        }

        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges && product.isValid)
            {
                if(product.IsNew)
                {
                    // call an insert stored procedure
                } else
                {
                    // call an update stored procedure
                }
            }
            
            return success;
        }
    }
}
