using OpeningTask.AreaCalculator.Shapes;
using Xunit;

namespace OpeningTask.AreaCalculator.Tests;

/// <summary>
/// Тесты для <see cref="Circle"/>
/// </summary>
public class CircleTests
{
    [Fact]
    public void Area_Radius3_ReturnsExpectedArea()
    {
        // arrange
        var circle = new Circle(3);
        var expectedArea = Math.PI * 3 * 3;

        // act
        var actualResult = circle.Area();
        
        // assert
        Assert.Equal(expectedArea, actualResult, 1e-10);
    }
}