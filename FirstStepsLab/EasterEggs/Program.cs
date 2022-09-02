using System;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int red = 0;
            int blue = 0;
            int green = 0;
            int orange = 0;
            
            for (int i = 0; i < number; i++)
            {
                string colour = Console.ReadLine();

                switch (colour)
                {
                    case "red":
                        red++;
                        break;
                    case "blue":
                        blue++;
                        break;
                    case "green":
                        green++;
                        break;
                    case "orange":
                        orange++;
                        break;
                }
            }

            Console.WriteLine("Red eggs: " + red);
            Console.WriteLine("Orange eggs: " + orange);
            Console.WriteLine("Blue eggs: " + blue);
            Console.WriteLine("Green eggs: " + green);

            if (red > blue && red > green && red > orange)
            {
                Console.WriteLine("Max eggs: " + red + " -> red");
            }
            else if (orange > red && orange > blue && orange > green)
            {
                Console.WriteLine("Max eggs: " + orange + " -> orange");
            }
            else if (blue > orange && blue > green && blue > red)
            {
                Console.WriteLine("Max eggs: " + blue + " -> blue");
            }
            else if (green > blue && green > red && green > blue)
            {
                Console.WriteLine("Max eggs: " + green + " -> green");
            }
        }
    }
}
