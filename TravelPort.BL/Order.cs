﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Training
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

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> orderItems { get; set; }

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

        public override string ToString()
        {
            return OrderDate.Value.Date + " (" + OrderId + ")";
        }
    }
}
