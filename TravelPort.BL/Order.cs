using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPort.BL
{
    public class Order
    {
        public Order()
        {
                
        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        public bool Save()
        {
            // code that saves defined order
            return true;
        }

        

        public bool Validate()
        {
            var isValid = true;

            if(OrderDate == null)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
