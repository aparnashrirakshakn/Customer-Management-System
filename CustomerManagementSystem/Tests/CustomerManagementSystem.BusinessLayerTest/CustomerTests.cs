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

    }
}