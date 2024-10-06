using OpeningTask.AreaCalculator.Shapes;
using Xunit;

namespace OpeningTask.AreaCalculator.Tests;

/// <summary>
/// Тесты для <see cref="AreaCalculator"/>
/// </summary>
public class AreaCalculatorTests
{
    private readonly Calculators.AreaCalculator _calculator;
    
    /// <summary>
    /// Конструктор
    /// </summary>
    public AreaCalculatorTests()
    {
        _calculator = new Calculators.AreaCalculator();
    }
    
    [Fact]
    public void CalculateArea_Circle_ReturnsExpectedArea()
    {
        // arrange
        var circle = new Circle(3);
        var expectedArea = Math.PI * 3 * 3;
        
        // act
        var actualArea = _calculator.CalculateArea(circle);
        
        // assert
        Assert.Equal(expectedArea, actualArea, 1e-10);
    }

    [Fact]
    public void CalculateArea_Triangle_ReturnsExpectedArea()
    { 
        // arrange
        var triangle = new Triangle(3, 4, 5);
        var expectedArea = 6;
        
        // act
        var actualArea = _calculator.CalculateArea(triangle);
        
        // assert
        Assert.Equal(expectedArea, actualArea, 1e-10);
    }
}