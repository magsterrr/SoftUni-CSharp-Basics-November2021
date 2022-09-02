using System;

namespace EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            string date0 = "21-23";
            string date1 = "24-27";
            string date2 = "28-31";

            if (destination == "France")
            {
                if (dates == date0)
                {
                    Console.WriteLine("Easter trip to France : {0:F2} leva.", nights * 30);
                }
                if (dates == date1)
                {
                    Console.WriteLine("Easter trip to France : {0:F2} leva.", nights * 35);

                }
                if (dates == date2)
                {
                    Console.WriteLine("Easter trip to France : {0:F2} leva.", nights * 40);

                }
            }

            if (destination == "Germany")
            {
                if (dates == date0)
                {
                    Console.WriteLine("Easter trip to Germany : {0:F2} leva.", nights * 32);
                }
                if (dates == date1)
                {
                    Console.WriteLine("Easter trip to Germany : {0:F2} leva.", nights * 37);

                }
                if (dates == date2)
                {
                    Console.WriteLine("Easter trip to Germany : {0:F2} leva.", nights * 43);

                }
            }

            if (destination == "Italy")
            {
                if (dates == date0)
                {
                    Console.WriteLine("Easter trip to Italy : {0:F2} leva.", nights * 28);
                }
                if (dates == date1)
                {
                    Console.WriteLine("Easter trip to Italy : {0:F2} leva.", nights * 32);

                }
                if (dates == date2)
                {
                    Console.WriteLine("Easter trip to Italy : {0:F2} leva.", nights * 39);

                }
            }
        }
    }
}
