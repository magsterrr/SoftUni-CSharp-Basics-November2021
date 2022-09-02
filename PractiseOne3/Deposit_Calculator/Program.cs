using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            // да прочетем 3 реда от конзолата и да ги запазим в три променливи double
            //изчесление - да намерим сумата

             double depositSum = double.Parse(Console.ReadLine());
             int months = int.Parse(Console.ReadLine());
             double percent = double.Parse(Console.ReadLine());

             double interestSum = depositSum * (percent / 100);
             double interestMonth = interestSum / 12;
             double sum = depositSum + months * interestMonth;

             Console.WriteLine(sum);
           



        }
    }
}
