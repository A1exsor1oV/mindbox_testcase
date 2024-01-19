using System;

namespace geometry_lib
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            // Формула Герона
            double p = (SideA + SideB + SideC) / 2; // полупериметр
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)); // площадь
        }

        public bool IsRightTriangle()
        {
            // Прямоугольный ли треугольник
            return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2)
                || Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2)
                || Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2);
        }
    }
}
