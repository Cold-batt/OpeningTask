using OpeningTask.AreaCalculator.Shapes;
using Xunit;

namespace OpeningTask.AreaCalculator.Tests;

/// <summary>
/// Тесты для <see cref="Triangle"/>
/// </summary>
public class TriangleTests
{
    [Fact]
    public void Area_Sides345_ReturnsExpectedArea()
    {
        // arrange
        var triangle = new Triangle(3, 4, 5);
        var expectedArea = 6;
        
        // act
        var actualResult = triangle.Area();
        
        // assert
        Assert.Equal(expectedArea, actualResult, 1e-10);
    }

    [Fact]
    public void IsRightTriangle_Sides345_ReturnsTrue()
    {
        // arrange
        var triangle = new Triangle(3, 4, 5);
        
        // act
        var actualResult = triangle.IsRightTriangle();
        
        // assert
        Assert.True(actualResult);
    }

    [Fact]
    public void IsRightTriangle_Sides123_ReturnsFalse()
    {
        // arrange
        var triangle = new Triangle(1, 2, 3);
        
        // act
        var actualResult = triangle.IsRightTriangle();
        
        // assert
        Assert.False(actualResult);
    }
}