using System;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            string geometryFigure = Console.ReadLine();
            double result = 0;
            switch (geometryFigure)
            {
                case "triangle":
                    double triangleSideA = double.Parse(Console.ReadLine());
                    double triangleSideB = double.Parse(Console.ReadLine());
                    result = GetTriangleAria(triangleSideA, triangleSideB);
                    break;
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    result = GetSquareAria(squareSide);
                    break;
                case "rectangle":
                    double rectangleSideA = double.Parse(Console.ReadLine());
                    double rectangleSideB = double.Parse(Console.ReadLine());
                    result = GetRectangleAria(rectangleSideA, rectangleSideB);
                    break;
                case "circle":
                    double circleRadius = double.Parse(Console.ReadLine());
                    result = GetCircleAria(circleRadius);
                    break;
            }

            Console.WriteLine($"{result:f2}");
        }

        private static double GetTriangleAria(double triangleSideA, double triangleSideB)
        {
            return triangleSideA * triangleSideB / 2;
        }
        
        private static double GetSquareAria(double squareSide)
        {
            return squareSide * squareSide;
        }

        private static double GetRectangleAria(double rectangleSideA, double rectangleSideB)
        {
            return rectangleSideA * rectangleSideB;
        }               

        private static double GetCircleAria(double circleRadius)
        {
            return Math.PI * circleRadius * circleRadius;
        }

    }
}
