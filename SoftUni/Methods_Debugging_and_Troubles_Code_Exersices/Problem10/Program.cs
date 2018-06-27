using System;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            Console.WriteLine("{0:f2}", Parameter(side, parameter));

        }

        static double Parameter(double side, string parameter)
        {
            double output = 0;

            if (parameter == "face")
            {
                output = Math.Sqrt(2 * (side * side));
            }
            else if (parameter == "space")
            {
                output = Math.Sqrt(3 * (side * side));
            }
            else if (parameter == "volume")
            {
                output = side * side * side;
            }
            else if (parameter == "area")
            {
                output = Math.Pow(side, 2) * 6;
            }
            return output;
        }
    }
}
