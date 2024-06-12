using Application;

namespace TestProject
{
    public class ReverseStringTests
    {
        private readonly IReverseStringService _reverseStringService;

        public ReverseStringTests()
        {
            _reverseStringService = new ReverseStringService();
        }

        /// <summary>
        /// Test IF Input String is NULL Then Result will be Empty String
        /// </summary>
        [Fact]
        public void GetReverseString_InputIsNull_ReturnsEmptyString()
        {
            // Arrange
            string input = null;

            // Act
            var result = _reverseStringService.GetReverseString(input);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        /// <summary>
        /// Test IF Input String is Empty Then Result will be Empty String
        /// </summary>
        [Fact]
        public void GetReverseString_InputIsEmpty_ReturnsEmptyString()
        {
            // Arrange
            string input = string.Empty;

            // Act
            var result = _reverseStringService.GetReverseString(input);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        /// <summary>
        /// Test IF Input String chacters more than 5 THEN Reverse It
        /// </summary>
        [Fact]
        public void GetReverseString_InputCharIsMoreThan5_ReturnsReversedString()
        {
            // Arrange
            string input = "ABCDEF";

            // Act
            var result = _reverseStringService.GetReverseString(input);

            // Assert
            Assert.Equal("FEDCBA", result);
        }

        /// <summary>
        /// Test IF Input String chacters less than 5 THEN return as it's
        /// </summary>
        [Fact]
        public void GetReverseString_InputCharLessThan5_ReturnsSameCharacter()
        {
            // Arrange
            string input = "ABC";

            // Act
            var result = _reverseStringService.GetReverseString(input);

            // Assert
            Assert.Equal("ABC", result);
        }
    }
}