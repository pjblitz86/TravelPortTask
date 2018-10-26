using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPort.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public int ProductId { get; set; }
        public Decimal? CurrentPrice { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

    }
}
