using System;

namespace problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            int ingredientsCounter = 0;
            while (isRunning)
            {
                string inputIngredient = Console.ReadLine();
                if (inputIngredient == "Bake!")
                {
                    isRunning = false;
                }
                else
                {
                    ingredientsCounter++;
                    Console.WriteLine("Adding ingredient {0}.", inputIngredient);
                        
                        

                }
            }
            Console.WriteLine($"Preparing cake with {ingredientsCounter} ingredients.");

        }
    }
}
