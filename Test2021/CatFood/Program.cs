using System;

namespace CatFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int cats = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            double price = 12.45;
            double sumPrice = 0;

            for (int i = 0; i < cats; i++)
            {
                double gramsPerCat = double.Parse(Console.ReadLine());

                if (gramsPerCat >= 100 && gramsPerCat <200)
                {
                    group1++;
                    sumPrice = sumPrice + (gramsPerCat / 1000) * price;
                }
                if (gramsPerCat >= 200 && gramsPerCat < 300)
                {
                    group2++;
                    sumPrice = sumPrice + (gramsPerCat / 1000) * price;

                }
                if (gramsPerCat >= 300 && gramsPerCat <= 400)
                {
                    group3++;
                    sumPrice = sumPrice + (gramsPerCat / 1000) * price;

                }

            }

            Console.WriteLine("Group 1: " + group1 + " cats.");
            Console.WriteLine("Group 2: " + group2 + " cats.");
            Console.WriteLine("Group 3: " + group3 + " cats.");
            Console.WriteLine("Price for food per day: {0:F2} lv.", sumPrice);
        }
    }
}
