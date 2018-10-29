using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using TravelPortTask;

namespace TravelPortTaskTests
{
    [TestClass]
    public class CustomerTests
    {
        ICustomer customer;

        [TestInitialize]
        public void TestIn()
        {
             customer = Substitute.For<ICustomer>();
        }

        [TestMethod]
        public void TestMethod1()
        {
        
            customer.calculateCustomerTaxVAT(true, true, true).Returns(5);
            var res = customer.calculateCustomerTaxVAT(true, true, true);
            Assert.AreEqual(res, 5);
        }
    }
}
