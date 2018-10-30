using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using TravelPortTask;

namespace TravelPortTaskTests
{
    [TestClass]
    public class NsubVATTests
    {
        Customer customer = new Customer();
        Supllier supllier = new Supllier();
        VATService vatService = new VATService();

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
