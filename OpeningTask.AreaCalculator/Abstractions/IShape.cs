namespace OpeningTask.AreaCalculator.Abstractions;

/// <summary>
/// Фигура
/// </summary>
public interface IShape
{
    /// <summary>
    /// Вычислить площадь
    /// </summary>
    /// <returns>Площадь фигуры</returns>
    public double Area();
}