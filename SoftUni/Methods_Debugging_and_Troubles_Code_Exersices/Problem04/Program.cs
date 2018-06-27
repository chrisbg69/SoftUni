using System;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = decimal.Parse(Console.ReadLine());
            var reversedNumber = GetReversedNumber(number);
            Console.WriteLine(reversedNumber);
        }

        static decimal GetReversedNumber(decimal number)
        {
            char[] reverseNumberArray = number.ToString().ToCharArray();
            Array.Reverse(reverseNumberArray);
            return decimal.Parse(new string(reverseNumberArray));
        }
    }
}
