using OpeningTask.AreaCalculator.Abstractions;

namespace OpeningTask.AreaCalculator.Shapes;

/// <summary>
/// Круг
/// </summary>
public class Circle : IShape
{
    /// <summary>
    /// Радиус круга
    /// </summary>
    public double Radius { get; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="radius">Радиус круга</param>
    public Circle(double radius)
    {
        Radius = radius;
    }
    
    /// <inheritdoc />
    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}