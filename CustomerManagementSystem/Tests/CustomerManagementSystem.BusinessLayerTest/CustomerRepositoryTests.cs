using CustomerManagementSystem.BusinessLayer;
using NUnit.Framework;

namespace CustomerManagementSystem.BusinessLayerTest
{
    public class CustomerRepositoryTests
    {
        [Test]
        public void Valid_CustomerId_Retrieves_Valid_Customer()
        {
            // Arrange
            CustomerRepository customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                Email = "myvalidemail@email.me",
                FirstName = "Aparna",
                LastName = "Shriraksha"
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.Email, actual.Email);
        }
    }
}
