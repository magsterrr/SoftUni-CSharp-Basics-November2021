using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            // read from the console - save in type double USD
            // calculate
            // write BGN

            double USD = double.Parse(Console.ReadLine());

            double BGN = USD * 1.79549;

            Console.WriteLine(BGN);

        }
    }
}
