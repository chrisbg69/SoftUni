using System;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            try
            {
                long.Parse(numberString);
                Console.WriteLine("integer");
            }
            catch (Exception)
            {
                try
                {
                    decimal.Parse(numberString);
                    Console.WriteLine("floating-point");
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
