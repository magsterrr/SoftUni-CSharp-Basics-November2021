using System;

namespace KingVsGodzilla
{
    class Program
    {
        static void Main(string[] args)
        {
            int filming = int.Parse(Console.ReadLine());
            int scenes = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());

            double preparing = filming * 0.15;
            int timeForScenes = scenes * time;
            int total = (int)preparing + timeForScenes;
            if (total > filming)
            {
                Console.WriteLine("Time is up! To complete the movie you need " + (total - filming) + " minutes.");
            }
            else
            {
                Console.WriteLine("You managed to finish the movie on time! You have " + (filming - total) + " minutes left!");
            }
        }
    }
}
