using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training;

namespace Training.Tests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FirstNameValid()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "TestName";

            string expected = "TestName";

            // Act
            string actual = customer.FirstName;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "Test";

            string expected = "Test";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer();
            customer.LastName = "Test";

            string expected = "Test";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var customer1 = new Customer();
            customer1.FirstName = "Test1";
            Customer.InstanceCount += 1;

            var customer2 = new Customer();
            customer2.FirstName = "Test2";
            Customer.InstanceCount += 1;

            var customer3 = new Customer();
            customer3.FirstName = "Test3";
            Customer.InstanceCount += 1;

            // Act

            // Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer();
            customer.LastName = "TestName";
            customer.Contact = "TestContact";

            var expected = true;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            var customer = new Customer();
            customer.Contact = "TestContact";

            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
