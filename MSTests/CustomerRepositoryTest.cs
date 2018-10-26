using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TravelPort.BL;

namespace MSTests
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                Contact = "test@gmail.com",
                FirstName = "testFirstName",
                LastName = "testLastName",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "testStreet01",
                        StreetLine2 = "testStreet02",
                        City = "TestCity01",
                        State = "TestState01",
                        Country = "TestCountry01",
                        PostalCode = "444"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "testStreet03",
                        StreetLine2 = "testStreet04",
                        City = "TestCity02",
                        State = "TestState02",
                        Country = "TestCountry02",
                        PostalCode = "333"
                    }
                }
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.Contact, actual.Contact);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
        
    }
}
