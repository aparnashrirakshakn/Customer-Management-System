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

        [Test]
        public void Save_Returns_Success_As_True_On_Valid_Product()
        {
            // Arrange
            ProductRepository productRepository = new ProductRepository();

            Product updatedProduct = new Product(2)
            {
                CurrentPrice = 30.00,
                ProductDescription = "An autobiography of one of the most loved men in India - Dr. A.P.J Abdul Kalam",
                ProductName = "Wings of Fire",
                HasChanges = true
            };

            // Act
            var actual = productRepository.Save(updatedProduct);

            // Assert
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void Save_Returns_Success_As_False_On_Invalid_Product()
        {
            // Arrange
            ProductRepository productRepository = new ProductRepository();

            Product updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "An autobiography of one of the most loved men in India - Dr. A.P.J Abdul Kalam",
                ProductName = "Wings of Fire",
                HasChanges = true
            };

            // Act
            var actual = productRepository.Save(updatedProduct);

            // Assert
            Assert.AreEqual(false, actual);
        }
    }
}

