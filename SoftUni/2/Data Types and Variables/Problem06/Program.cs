using System;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    for (int k = 0; k < num; k++)
                    {
                        char letterA = (char)('a' + i);
                        char letterB = (char)('a' + j);
                        char letterC = (char)('a' + k);
                        Console.WriteLine($"{letterA}{letterB}{letterC}");
                    }
                }
            }
        }
    }
}
