using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPort.BL
{
    public class Product: EntityBase
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public int ProductId { get; set; }
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        private string _ProductName;

        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        public override bool Validate()
        {
            var isValid = true;
            if(string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }
            if (CurrentPrice == null)
            {
                isValid = false;
            }
            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }

        

    }
    
}
