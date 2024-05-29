using Xunit;

namespace Atividade13.Tests
{
    public class FactorialCalculatorTest
    {
        [Fact]
        public void Calculate_ValidInput_ReturnsCorrectFactorial()
        {
            // Arrange
            var calculator = new FactorialCalculator();

            // Act & Assert
            Assert.Equal(1, calculator.Calculate(0));
            Assert.Equal(1, calculator.Calculate(1));
            Assert.Equal(2, calculator.Calculate(2));
            Assert.Equal(6, calculator.Calculate(3));
            Assert.Equal(24, calculator.Calculate(4));
            Assert.Equal(120, calculator.Calculate(5));
            Assert.Equal(720, calculator.Calculate(6));
            Assert.Equal(5040, calculator.Calculate(7));
            Assert.Equal(40320, calculator.Calculate(8));
            Assert.Equal(362880, calculator.Calculate(9));
            Assert.Equal(3628800, calculator.Calculate(10));
        }

        [Fact]
        public void Calculate_NegativeInput_ThrowsArgumentException()
        {
            // Arrange
            var calculator = new FactorialCalculator();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => calculator.Calculate(-1));
        }
    }
}
