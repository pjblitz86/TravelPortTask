using System;
using System.Collections.Generic;
using System.Text;

namespace TravelPort.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            // instance of the Product class
            Order order = new Order(orderId);

            // code that retrieves Product

            // temporary hard code for populating order
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset();
            }
            return order;
        }

        public bool Save()
        {
            // code that saves defined product
            return true;
        }
    }
}
