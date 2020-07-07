using System;

namespace Geron_formula
{
    class Program
    {
        static void Main(string[] args)
        {
            float sideSizeA = GetSideOfTriagle();
            float sideSizeB = GetSideOfTriagle();
            float sideSizeC = GetSideOfTriagle();

            float sizeHalfPerimeter = CalculateHalfPerimeter(sideSizeA, sideSizeB, sideSizeC);
            double areaOfTriagle = CalculateAreaOfTriangle(sizeHalfPerimeter, sideSizeA, sideSizeB, sideSizeC);

            Console.WriteLine($"Площадь треугольника равна: {areaOfTriagle}");

        }

        static float GetSideOfTriagle()
        {
            string sideSize = Console.ReadLine();
            float resultSideSize = float.Parse(sideSize);

            return resultSideSize;
        }

        static float CalculateHalfPerimeter(float sideSizeA, float sideSizeB, float sideSizeC)
        {
            return (sideSizeA + sideSizeB + sideSizeC) / 2;
        }

        static double CalculateAreaOfTriangle(float halfPerimeter, float sideA, float sideB, float sideC)
        {
            // Площадь треугольника вычисляется по формуле герона.
            double areaOfTriagleInSqrt = halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC);
            double areaOfTriagle = Math.Sqrt(areaOfTriagleInSqrt);

            return areaOfTriagle;
        }

    }
}
