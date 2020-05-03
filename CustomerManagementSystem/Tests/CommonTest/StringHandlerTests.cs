using Common;
using NUnit.Framework;

namespace CommonTest
{
    public class StringHandlerTests
    {
        [Test]
        public void InsertSpaces_Returns_String_With_Spaces_For_Valid_String()
        {
            // Arrange
            var source = "InsertSpaces";
            var expected = "Insert Spaces";
            var handler = new StringHandler();

            // Act
            var actual = handler.InsertSpaces(source);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InsertSpaces_Returns_String_With_Only_One_Space_For_A_String_With_Existing_Space()
        {
            // Arrange
            var source = "Insert Spaces";
            var expected = "Insert Spaces";
            var handler = new StringHandler();

            // Act
            var actual = handler.InsertSpaces(source);

            // Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}