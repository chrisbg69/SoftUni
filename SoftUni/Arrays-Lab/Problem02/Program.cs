using System;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());

            int[] intArray = new int[arraySize];
            for (int i = arraySize - 1; i >= 0; i--)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", intArray));
        }
    }
}
