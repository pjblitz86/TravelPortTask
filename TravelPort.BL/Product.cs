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
        public double? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }
    }
}
