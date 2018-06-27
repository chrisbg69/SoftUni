using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double priceWater = 0.70 * quantity;
            double priceCofee = 1.00 * quantity;
            double priceBeer = 1.70 * quantity;
            double priceTea = 1.20 * quantity;


            if (profession == "Athlete")
            {
                Console.WriteLine($"The {profession} has to pay {priceWater:f2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine($"The {profession} has to pay {priceCofee:f2}.");
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine($"The {profession} has to pay {priceBeer:f2}.");
            }
            else
            {
                Console.WriteLine($"The {profession} has to pay {priceTea:f2}.");
            }
        }
    }
}
