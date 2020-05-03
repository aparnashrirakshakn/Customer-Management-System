using CustomerManagementSystem.BusinessLayer;
using NUnit.Framework;


namespace CustomerManagementSystem.BusinessLayerTest
{
    public class ProductRepositoryTests
    {
        [Test]
        public void Valid_ProductId_Retrieves_Valid_Product()
        {
            // Arrange
            ProductRepository productRepository = new ProductRepository();

            var expected = new Product(2)
            {
                ProductName = "Wings of Fire",
                ProductDescription = "An autobiography of one of the most loved men in India - Dr. A.P.J Abdul Kalam",
                CurrentPrice = 25.00
            };

            // Act
            var actual = productRepository.Retrieve(2);

            // Assert
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);

        }
    }
}
