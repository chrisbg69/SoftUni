﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            for (int i = intList.Count - 1; i > 0; i--)
            {
                for (int j = 0; j < intList.Count; j++)
                {
                    if (j + 1 < intList.Count)
                    {
                        intList[j] += intList[j + 1];
                    }
                    else
                    {
                        intList.RemoveRange(intList.Count - 1, 1);
                    }
                }
            }

            Console.WriteLine(intList[0]);
        }
    }
}
