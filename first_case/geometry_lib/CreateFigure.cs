using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry_lib
{
    // Класс для создания фигур
    public static class CreateFigure
    {
        public static IShape CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        public static IShape CreateTriangle(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }
    }
}
