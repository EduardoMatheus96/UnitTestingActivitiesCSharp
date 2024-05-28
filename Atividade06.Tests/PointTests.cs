using Atividade06;
using NSubstitute;
using Xunit;

public class PointTests
{
    [Fact]
    public void DistanceTo_ValidPoint_ReturnsCorrectDistance()
    {
        // Arrange
        var pointA = new Point(0, 0);
        var pointB = new Point(3, 4);
        
        // Act
        var distance = pointA.DistanceTo(pointB);
        
        // Assert
        Assert.Equal(5, distance);
    }

}
