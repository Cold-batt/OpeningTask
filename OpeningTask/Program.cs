using OpeningTask.AreaCalculator.Shapes;

namespace OpeningTask;

class Program
{
    public static void Main(string[] args)
    {
        var circle = new Circle(1);
        var triangle = new Triangle(3, 4, 5);

        var calculator = new AreaCalculator.Calculators.AreaCalculator();

        Console.WriteLine($"Площадь круга: {calculator.CalculateArea(circle)}");
        Console.WriteLine($"Площадь треугольника: {calculator.CalculateArea(triangle)}");

        Console.WriteLine($"{triangle.IsRightTriangle()}");
    }
}
