 using System;

namespace WhileCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            string enteredPass = Console.ReadLine();
            string pass = "obichamPapesh";

            while (pass != enteredPass)
            {
                Console.WriteLine("Wrong password! Please try again.");

                enteredPass = Console.ReadLine();
            }
            if (enteredPass == pass)
            {
                Console.WriteLine("Welcome!");
            }
        }
    }
}
