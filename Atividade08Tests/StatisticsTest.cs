using System;
using System.Collections.Generic;
using Xunit;

namespace Atividade08.Tests
{
    public class StatisticsTests
    {
        [Fact]
        public void CalculateAverage_WithValidNumbers_ReturnsCorrectAverage()
        {
            // Arrange
            var statistics = new Statistics();
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            
            // Act
            var average = statistics.CalculateAverage(numbers);
            
            // Assert
            Assert.Equal(3, average);
        }

        [Fact]
        public void CalculateAverage_WithEmptyList_ThrowsArgumentException()
        {
            // Arrange
            var statistics = new Statistics();
            var numbers = new List<int>();
            
            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => statistics.CalculateAverage(numbers));
            Assert.Equal("The list of numbers cannot be empty", exception.Message);
        }

        [Fact]
        public void CalculateAverage_WithNullList_ThrowsArgumentException()
        {
            // Arrange
            var statistics = new Statistics();
            List<int> numbers = null;
            
            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => statistics.CalculateAverage(numbers));
            Assert.Equal("The list of numbers cannot be empty", exception.Message);
        }
    }
}
