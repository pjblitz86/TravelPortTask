using System;
using System.Collections.Generic;
using System.Text;

namespace Training
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

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            // code that retrieves the defined order fields

            // temporary hard-coded data
            if (orderId == 10)
            {
                orderDisplay.FirstName = "TestFirstName";
                orderDisplay.LastName = "TestLastName";
                orderDisplay.OrderDate = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7,0,0));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "testStreet01",
                    StreetLine2 = "testStreet02",
                    City = "TestCity01",
                    State = "TestState01",
                    Country = "TestCountry01",
                    PostalCode = "444"
                };
            }
            orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();

            // code that retrieves the order items
                
            // temp hard-coded data
            if(orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "TestProduct1",
                    PurchasePrice = 14.44M,
                    OrderQuantity = 2
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "TestProduct2",
                    PurchasePrice = 4.44M,
                    OrderQuantity = 1
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
            }
            return orderDisplay;
        }

        public bool Save()
        {
            // code that saves defined product
            return true;
        }
    }
}
