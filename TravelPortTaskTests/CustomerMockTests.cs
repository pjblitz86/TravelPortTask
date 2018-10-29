using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelPortTask;

namespace TravelPortTaskTests
{
    [TestClass]
    public class CustomerMockTests
    {
        ICustomer customer;
        public CustomerMockTests()
        {
           customer = new Customer();
           customer.isSupllierVATPayer = true;
        }

        [TestMethod]
        public void TaxCalculation_SupllierNotVATTest()
        {
            // Arrange
            customer.isSupllierVATPayer = false;
            var expected = 0;
            
            // Act
            var actual = customer.calculateCustomerTaxVAT(true, true, true, "lt");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // VAT supllier

        [TestMethod]
        public void TaxCalculation_CustomerNotEUTest()
        {
            // Arrange
            var expected = 0;

            // Act
            var actual = customer.calculateCustomerTaxVAT(false, true, true, "lt");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Customer in EU
        [TestMethod]
        public void TaxCalculation_EU_notVAT_diffCountryTest()
        {
            // Arrange
            var expected = 0.19;

            // Act
            var actual = customer.calculateCustomerTaxVAT(true, false, false, "DE");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaxCalculation_EU_isVAT_diffCountryTest()
        {
            // Arrange
            var expected = 0.0;

            // Act
            var actual = customer.calculateCustomerTaxVAT(true, true, false, "DE");

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TaxCalculation_EU_isVAT_sameCountryTest()
        {
            // Arrange
            var expected = 0.21;

            // Act
            var actual = customer.calculateCustomerTaxVAT(true, true, true, "lt");

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
