using System;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());

            bool isPrime = GetNumPrimeStatus(number);
            Console.WriteLine(isPrime);
        }

        static bool GetNumPrimeStatus(long number)
        {

            if (number < 2)
            {
                return false;
            }
            if (number < 4)
            {
                return true;
            }
            for (int i = 5; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
