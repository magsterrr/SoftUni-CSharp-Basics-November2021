using System;

namespace Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Първоначално играчът започва с 301 точки.
            int maxPoints = 301;
            int shotsCounter = 0;
            string name = Console.ReadLine();
            // Три сектора, които умножават точките - Single x 1, Double x 2, Triple x 3
            // Получените точки се вадят от общия брой (301) докато не стигнат 0
            // При изстрел, даващ повече точки от наличните, той се счита като неуспешен
            // 1. чете се името на играча
            // 2. до получаване на команда retire се четат многократно по два реда
            // - single / double / triple
            // играта приключва или при retire или при 0 точкi
            // "{името на играча} won the leg with {успешните изстрели} shots."
            //"{името на играча} retired after {неуспешни изстрели} unsuccessful shots.

            while (maxPoints != 0)
            {
                string multiplier = Console.ReadLine();
                int points = int.Parse(Console.ReadLine());
                shotsCounter++;

                if (true)
                {

                }
            }

        }
    }
}
