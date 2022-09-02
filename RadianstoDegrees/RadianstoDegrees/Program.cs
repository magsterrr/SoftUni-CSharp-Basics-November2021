using System;

namespace RadianstoDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //от конзолата получаваме: radians
            //преобразуваме в degrees => degrees=radians*180/Math.PI
            //отпечатваме degrees


            double radians = double.Parse (Console.ReadLine());

            double degrees = radians * 180 / Math.PI;

            Console.WriteLine(degrees);

        }
    }
}
