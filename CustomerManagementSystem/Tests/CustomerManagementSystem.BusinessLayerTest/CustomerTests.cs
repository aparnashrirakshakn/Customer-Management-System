using CustomerManagementSystem.BusinessLayer;
using NUnit.Framework;

namespace CustomerManagementSystem.BusinessLayerTest
{
    public class CustomerTests
    {
        [Test]
        public void Valid_FirstName_And_LastName_Returns_Valid_FullName()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Aparna",
                LastName = "Shriraksha"
            };

            string expected = "Shriraksha, Aparna";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Valid_FirstName_And_No_LastName_Returns_Valid_FullName()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Aparna"
            };
            string expected = "Aparna";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void No_FirstName_And_Valid_LastName_Returns_Valid_FullName()
        {
            //Arrange
            Customer customer = new Customer
            {
                LastName = "Shriraksha"
            };
            string expected = "Shriraksha";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}