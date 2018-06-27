using System;
using System.Linq;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            int firsNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int[] numbers = { firsNumber, secondNumber, thirdNumber };

            Console.WriteLine(numbers.Max());


        }

    }
}

