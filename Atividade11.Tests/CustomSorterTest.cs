
using System.Collections.Generic;
using Xunit;

namespace Atividade11.Tests
{
    public class CustomSorterTest
    {
        [Fact]
        public void SortDescending_WithUnsortedList_ReturnsSorted()
        {
            // Arrange
            var sorter = new CustomSorter();
            var numbers = new List<int> { 3, 1, 2 };

            // Act
            var result = sorter.SortDescending(numbers);

            // Assert
            Assert.Equal(new List<int> { 3, 2, 1 }, result);
        }

        [Fact]
        public void SortDescending_WithEmptyList_ReturnsEmpty()
        {
            // Arrange
            var sorter = new CustomSorter();
            var numbers = new List<int>();

            // Act
            var result = sorter.SortDescending(numbers);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void SortDescending_WithNullList_ThrowsArgumentNullException()
        {
            // Arrange
            var sorter = new CustomSorter();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => sorter.SortDescending(null));
        }
    }
}
