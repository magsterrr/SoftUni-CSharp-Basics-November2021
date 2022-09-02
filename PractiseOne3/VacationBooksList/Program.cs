using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {


            int pageBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysForThisBook = int.Parse(Console.ReadLine());


            int hoursForBook = pageBook / pagesPerHour;
            int hoursPerDay = hoursForBook / daysForThisBook;

            Console.WriteLine(hoursPerDay);


        }
    }
}
