using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {            int Pens = int.Parse(Console.ReadLine());
            int Markers = int.Parse(Console.ReadLine());
            int Cleaner = int.Parse(Console.ReadLine());
            double Discount = double.Parse(Console.ReadLine());

            double pricePens = 5.80;
            double priceMarkers = 7.20;
            double priceCleaner = 1.20;
            double sumNoDisc = pricePens*Pens + priceMarkers*Markers + priceCleaner*Cleaner;

            double discountPerc = Discount / 100;
            double discountPrice = sumNoDisc - sumNoDisc * discountPerc;

            Console.WriteLine(discountPrice);







        }
    }
}
