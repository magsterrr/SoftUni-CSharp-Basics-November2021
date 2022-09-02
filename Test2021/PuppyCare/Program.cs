using System;

namespace PuppyCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int kgFood = int.Parse(Console.ReadLine());
            int boughtFood = kgFood * 1000;
            string command = "not addopted";
            int sumFood = 0;
            while (command != "Adopted")
            {
                command = (Console.ReadLine());
                if (command != "Adopted")
                {
                    sumFood = sumFood + int.Parse(command);
                }
            }
            if (sumFood < boughtFood)
            {
                int left = boughtFood - sumFood;
                Console.WriteLine("Food is enough! Leftovers: " + left + " grams.");

            }
            else if (sumFood >= boughtFood)
            {
                int more = sumFood - boughtFood;
                Console.WriteLine("Food is not enough. You need " + more + " grams more.");

            }
        }
    }
}
