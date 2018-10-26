using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPort.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        public bool Save()
        {
            // code that saves defined order item
            return true;
        }

        public OrderItem Retrieve(int orderItemId)
        {
            // code that retrieves defined order item
            return new OrderItem (orderItemId);
        }

        public bool Validate()
        {
            var isValid = true;

            if(OrderQuantity <=0)
            {
                isValid = false;
            }
            if(ProductId <=0)
            {
                isValid = false;
            }
            if(PurchasePrice == null)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
