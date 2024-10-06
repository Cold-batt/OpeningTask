using OpeningTask.AreaCalculator.Abstractions;

namespace OpeningTask.AreaCalculator.Calculators;

/// <summary>
/// Калькулятор площадей фигур
/// </summary>
public class AreaCalculator
{
    /// <summary>
    /// Вычисляет площадь заданной фигуры
    /// </summary>
    /// <param name="shape">Фигура, для которой вычисляется площадь</param>
    /// <returns>Площадь фигуры.</returns>
    public double CalculateArea(IShape shape)
    {
        return shape.Area();
    }
}
