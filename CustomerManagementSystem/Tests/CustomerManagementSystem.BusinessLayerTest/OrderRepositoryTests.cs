using CustomerManagementSystem.BusinessLayer;
using NUnit.Framework;
using System;

namespace CustomerManagementSystem.BusinessLayerTest
{
    class OrderRepositoryTests
    {
        [Test]
        public void Valid_OrderId_Retrieves_Valid_Order()
        {
            // Arrange
            OrderRepository orderRepository = new OrderRepository();

            var expected = new Order(3)
            {
                OrderDate = new DateTimeOffset(2007, 5, 1, 9, 0, 0, TimeSpan.Zero)
            };

            // Act
            var actual = orderRepository.Retrieve(3);

            // Assert
            Assert.AreEqual(expected.OrderId, actual.OrderId);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

        }

    }
}
