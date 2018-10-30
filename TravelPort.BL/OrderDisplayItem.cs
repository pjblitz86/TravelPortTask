using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    public class OrderDisplayItem
    {
        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public string ProductName { get; set; }
        public decimal? PurchasePrice { get; set; }
    }
}
