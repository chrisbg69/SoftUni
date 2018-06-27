﻿using System;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            PrintMessageSignOfNumber(number);
        }

        private static void PrintMessageSignOfNumber(long number)
        {
            Console.WriteLine(
                number > 0 ? $"The number {number} is positive." :
                number < 0 ? $"The number {number} is negative." :
                $"The number {number} is zero.");
        }
    }
}
