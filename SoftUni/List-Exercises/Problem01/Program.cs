using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            //read input
            //counter, maxCounter, maxNumber

            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxNumber = 0;
            int maxCounter = 0;

            foreach (int num1 in nums)
            {
                int counter = 0;
                foreach (int num2 in nums)
                {
                    if (num1 == num2)
                    {
                        counter++;
                    }
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    maxNumber = num1;
                }
            }
            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write($"{maxNumber} ");
            }
        }
    }
}
