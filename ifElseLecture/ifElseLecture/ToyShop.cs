using System;

namespace ifElseLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            double prPuzzle = 2.6;
            int prDoll = 3;
            double prBear = 4.1;
            double prMinion = 8.2;
            int prTruck = 2;
            double priceTrip = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());
            double amountMoney = (prPuzzle * puzzle) + (prDoll * doll) + (prBear * bear) + (prMinion * minion) + (prTruck * truck);
            double amount = puzzle + doll + bear + minion + truck;

            if (amount >=50)
            {
                amountMoney = amountMoney - amountMoney * 25 / 100;
            }
            amountMoney = amountMoney - amountMoney * 10 / 100;
            if (amountMoney >= priceTrip)
            {
                Console.WriteLine("Yes! {0:F2} lv left.", amountMoney - priceTrip);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:F2} lv needed.", priceTrip - amountMoney);
            }
        }
    }
}
