using System;

namespace ForCicle
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                switch (symbol)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
