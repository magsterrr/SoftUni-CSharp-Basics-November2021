using System;

namespace FirstStepsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double statues = rent - rent * 0.3;
            double catering = statues - statues * 0.15;
            double sound = catering / 2;
            double sum = rent + statues + catering + sound;
            Console.WriteLine("{0:F2}", sum);
        }
    }
}
