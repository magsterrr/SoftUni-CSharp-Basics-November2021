using System;

namespace GodzillaAgainstKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double outfit = double.Parse(Console.ReadLine());
            double decor = budget * 10 / 100;
            double outfits = outfit * people;
            if (people > 150)
            {
                outfits = outfit * people - outfit * people * 10 / 100;
            }
            double sum = decor + outfits;
            double left = budget - sum;
            if (sum <= budget)
            {
                Console.WriteLine("Action!\nWingard starts filming with {0:F2} leva left.", left);
            }
            if (sum > budget)
            {
                left = Math.Abs(sum - budget);
                Console.WriteLine("Not enough money!\nWingard needs {0:F2} leva more.", left);
            }
        }   
    }
}
