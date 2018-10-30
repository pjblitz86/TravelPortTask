using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using TravelPortTask;

namespace TravelPortTaskTests
{
    [TestClass]
    public class NsubVATTests
    {
        VATService vatService;
        Customer customer;
        Supllier supllier;

        [TestInitialize]
        public void TestIn()
        {
            vatService = Substitute.For<VATService>();
        }

        [TestMethod]
        public void VATServiceTest()
        {
            customer = new Customer();
            supllier = new Supllier();
            var expected = vatService.CalculateVAT(customer, supllier);
            var result = vatService.CalculateVAT(customer, supllier);
            Assert.AreEqual(result, expected);
        }
    }
}
