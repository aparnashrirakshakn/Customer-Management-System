using CustomerManagementSystem.BusinessLayer;
using CustomerManagementSystem.BusinessLayer.Enums;
using NUnit.Framework;
using System.Collections.Generic;

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

        [Test]
        public void Valid_CustomerId_Retrieves_Valid_Customer_With_Existing_Addresses()
        {
            // Arrange
            CustomerRepository customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                Email = "myvalidemail@email.me",
                FirstName = "Aparna",
                LastName = "Shriraksha",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = AddressType.Home,
                        StreetLine1 = "Street 1",
                        StreetLine2 = "Substreet 10",
                        City = "Hope City",
                        Country = "MerryLand",
                        PostalCode = "1234"
                    },

                    new Address()
                    {
                         AddressType = AddressType.Work,
                         StreetLine1 = "Street 9",
                         StreetLine2 = "Substreet 14",
                         City = "Hope City",
                         Country = "MerryLand",
                         PostalCode = "4321"
                    }
                }
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.Email, actual.Email);
            for(int i=0; i<1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
