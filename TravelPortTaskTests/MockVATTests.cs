using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelPortTask;

namespace TravelPortTaskTests
{
    [TestClass]
    public class MockVATTests
    {
        Customer customer = new Customer();
        Supllier supllier = new Supllier();
        VATService vatService = new VATService();

        // Supllier is not VAT
        [TestMethod]
        public void SupllierNotVATTest()
        {
            // Arrange
            supllier.IsVAT_TaxPayer = false;
            var expected = 0;

            // Act
            var actual = vatService.CalculateVAT(customer, supllier);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // supllier is VAT

        [TestMethod]
        public void CustomerNotEUTest()
        {
            // Arrange
            supllier.IsVAT_TaxPayer = true;
            customer.IsInEU = false;
            var expected = 0;

            // Act
            var actual = vatService.CalculateVAT(customer, supllier);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Customer in EU

        [TestMethod]
        public void CustEU_notVAT_diffCountryTest()
        {
            // Arrange
            supllier.IsVAT_TaxPayer = true;
            customer.IsVAT_TaxPayer = false;
            customer.IsInEU = true;
            customer.Country2DigitCode = "lt";
            supllier.Country2DigitCode = "de";

            var expected = 0.21;

            // Act
            var actual = vatService.CalculateVAT(customer, supllier);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustEU_isVAT_diffCountryTest()
        {
            // Arrange
            supllier.IsVAT_TaxPayer = true;
            customer.IsVAT_TaxPayer = true;
            customer.IsInEU = true;
            customer.Country2DigitCode = "lt";
            supllier.Country2DigitCode = "de";

            var expected = 0;

            // Act
            var actual = vatService.CalculateVAT(customer, supllier);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CustEU_isVAT_sameCountryTest()
        {
            // Arrange
            supllier.IsVAT_TaxPayer = true;
            customer.IsVAT_TaxPayer = true;
            customer.IsInEU = true;
            customer.Country2DigitCode = "de";
            supllier.Country2DigitCode = "de";

            var expected = 0.19;

            // Act
            var actual = vatService.CalculateVAT(customer, supllier);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
