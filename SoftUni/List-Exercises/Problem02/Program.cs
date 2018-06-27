using System;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            //read list
            //while loop
            //read input
            //split
            //change list
            //print odd or even
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string line = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

            }
            string[] tokens = line.Split();
            string command = tokens[0];
            switch (command)
            {
                case "Delete":
                    int numToRemove = int.Parse(tokens[1]);
                    numbers.RemoveAll(numbers => numbers == numToRemove);
                    break;
                case "Insert":
                    int element = int.Parse(tokens[])

                default:
                    break;
            }
        }
    }
}
