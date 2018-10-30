using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Training;

namespace Training.Tests
{
    [TestClass]
    public class RetrieveOrderDisplayTest
    {
        [TestMethod]
        public void FirstNameValid()
        {
            // Arrange
            var orderRepository = new OrderRepository();
            var expected = new OrderDisplay()
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                OrderDate = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
                ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "testStreet01",
                    StreetLine2 = "testStreet02",
                    City = "TestCity01",
                    State = "TestState01",
                    Country = "TestCountry01",
                    PostalCode = "444"
                },
                orderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        ProductName = "TestProduct1",
                        PurchasePrice = 14.44M,
                        OrderQuantity = 2
                    },
                    new OrderDisplayItem()
                    {
                        ProductName = "TestProduct2",
                        PurchasePrice = 4.44M,
                        OrderQuantity = 1
                    }

                }
            };

            // Act
            var actual = orderRepository.RetrieveOrderDisplay(10);

            // Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

            Assert.AreEqual(expected.ShippingAddress.AddressType, actual.ShippingAddress.AddressType);
            Assert.AreEqual(expected.ShippingAddress.StreetLine1, actual.ShippingAddress.StreetLine1);
            Assert.AreEqual(expected.ShippingAddress.City, actual.ShippingAddress.City);
            Assert.AreEqual(expected.ShippingAddress.State, actual.ShippingAddress.State);
            Assert.AreEqual(expected.ShippingAddress.Country, actual.ShippingAddress.Country);
            Assert.AreEqual(expected.ShippingAddress.PostalCode, actual.ShippingAddress.PostalCode);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.orderDisplayItemList[i].OrderQuantity, actual.orderDisplayItemList[i].OrderQuantity);
                Assert.AreEqual(expected.orderDisplayItemList[i].ProductName, actual.orderDisplayItemList[i].ProductName);
                Assert.AreEqual(expected.orderDisplayItemList[i].PurchasePrice, actual.orderDisplayItemList[i].PurchasePrice);
            }

        }
    }
}
