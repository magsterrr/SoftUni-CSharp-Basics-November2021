using System;

namespace Processors
{
    class Program
    {
        static void Main(string[] args)
        {
            int processorsPlanned = int.Parse(Console.ReadLine());
            int staff = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            double hoursTotal = (staff * workDays * 8)/3;
            double manufactored = Math.Floor(hoursTotal);


            if (manufactored < processorsPlanned)
            {
                double left = (processorsPlanned - manufactored);
                double loss = left * 110.10;
                Console.WriteLine("Losses: -> {0:F2} BGN", loss);
            }
            else if (processorsPlanned < manufactored)
            {
                double more = (manufactored - processorsPlanned);
                double profit = more * 110.10;
                Console.WriteLine("Profit: -> {0:F2} BGN", profit);
            }
        }
    }
}
