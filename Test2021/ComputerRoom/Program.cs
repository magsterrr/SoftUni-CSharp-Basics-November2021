using System;

namespace ComputerRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double price = 1;

            if (month == "march" || month == "april" || month == "may")
            {
                if (time == "day")
                    price = 10.50;
                if (time == "night")
                    price = 8.40;
            }

            if (month == "june" || month == "july" || month == "august")
            {
                if (time == "day")
                    price = 12.60;
                if (time == "night")
                    price = 10.20;

            }

            if (people >= 4)
            {
                price = price - (price * 0.1);
            }
            if (hours >= 5)
            {
                price = price - (price * 0.5);
            }

            double priceTotal = (price * people) * hours; 
            Console.WriteLine("Price per person for one hour: {0:F2}",price);
            Console.WriteLine("Total cost of the visit: {0:F2}", priceTotal);
        }
    }
}
