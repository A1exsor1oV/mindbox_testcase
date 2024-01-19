using System;

namespace geometry_lib
{
    class Program
    {
        static void Main()
        {
            IShape circle = CreateFigure.CreateCircle(5);
            Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");

            IShape triangle = CreateFigure.CreateTriangle(3, 4, 5);
            Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
            Console.WriteLine($"Прямоугольный треугольник: {((Triangle)triangle).IsRightTriangle()}");
        }
    }
}