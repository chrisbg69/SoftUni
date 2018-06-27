using System;

namespace Problem08
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosesPointToCenterpoint(x1, y1, x2, y2);

        }

        private static void PrintClosesPointToCenterpoint(double x1, double y1, double x2, double y2)
        {
            double point1Distance = x1 * x1 + y1 * y1;
            double point2Distance = x2 * x2 + y2 * y2;

            Console.WriteLine(point1Distance <= point2Distance ? $"({x1}, {y1})" : $"({x2}, {y2})");
        }
    }
}