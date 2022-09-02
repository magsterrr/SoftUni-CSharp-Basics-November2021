using System;

namespace Test2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceCard = int.Parse(Console.ReadLine());
            int priceConnector = int.Parse(Console.ReadLine());
            double electricityPerCard = double.Parse(Console.ReadLine());
            double incomePerCard = double.Parse(Console.ReadLine());
            int components = 1000;

            int cards = priceCard * 13;
            int connectors = priceConnector * 13;
            int investement = cards + connectors + components;

            double profitPerCard = incomePerCard - electricityPerCard;
            double profitPerDay = profitPerCard * 13;

            double days = investement / profitPerDay;
            Console.WriteLine(investement);
            Console.WriteLine(Math.Ceiling(days));
        }
    }
}
