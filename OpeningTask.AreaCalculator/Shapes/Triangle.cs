using OpeningTask.AreaCalculator.Abstractions;

namespace OpeningTask.AreaCalculator.Shapes;

/// <summary>
/// Треугольник
/// </summary>
public class Triangle : IShape
{
    /// <summary>
    /// Сторона A треугольника
    /// </summary>
    public double SideA { get; }

    /// <summary>
    /// Сторона B треугольника
    /// </summary>
    public double SideB { get; }

    /// <summary>
    /// Сторона C треугольника
    /// </summary>
    public double SideC { get; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="sideA">Сторона A треугольника</param>
    /// <param name="sideB">Сторона B треугольника</param>
    /// <param name="sideC">Сторона C треугольника</param>
    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    /// <inheritdoc />
    public double Area()
    {
        var s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    /// <summary>
    /// Проверяет, является ли треугольник прямоугольным
    /// </summary>
    /// <returns>true, если треугольник прямоугольный, иначе false</returns>
    public bool IsRightTriangle()
    {
        double[] sides = { SideA, SideB, SideC };
        Array.Sort(sides);
        return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 1e-10;
    }
}