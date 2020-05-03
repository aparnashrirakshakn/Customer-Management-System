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

        [Test]
        public void InstanceCount_Returns_Correct_Instance_Count()
        {
            //Arrange
            Customer customer1 = new Customer();
            Customer.InstanceCount += 1;

            Customer customer2 = new Customer();
            Customer.InstanceCount += 1;

            Customer customer3 = new Customer();
            Customer.InstanceCount += 1;

            //Act

            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [Test]
        public void Validate_Returns_IsValid_True_For_Valid_Values()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Shriraksha",
                Email = "myvalidemail@email.me"
            };

            // Act
            bool result = customer.Validate();

            // Assert
            Assert.IsTrue(result);
        }

        public void Validate_Returns_IsValid_False_For_Invalid_Values()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Aparna"
            };

            // Act
            bool result = customer.Validate();

            // Assert
            Assert.IsFalse(result);
        }
    }
}