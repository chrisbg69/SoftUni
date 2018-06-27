﻿using System;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int calories = 0;

            for (int i = 0; i < count; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese":
                        calories += 500;
                        break;
                    case "tomato sauce":
                        calories += 150;
                        break;
                    case "salami":
                        calories += 600;
                        break;
                    case "pepper":
                        calories += 50;
                        break;
                    default:
                        calories += 0;
                        break;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
