using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using TravelPortTask;

namespace TravelPortTaskTests
{
    [TestClass]
    public class CustomerNsubTests
    {
        ICustomer customer;

        [TestInitialize]
        public void TestIn()
        {
            customer = Substitute.For<ICustomer>();
        }

        [TestMethod]
        public void TaxCalculation_SupllierNotVATTest()
        {
            customer.calculateCustomerTaxVAT(true, true, true, "LT").Returns(0);
            var res = customer.calculateCustomerTaxVAT(true, true, true, "lt");
            Assert.AreEqual(res, 0);
        }
    }
}
