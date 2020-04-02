using System;

namespace Savings_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money will you save a week");
            double money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What interest rate will you receive");
            double rate = Convert.ToDouble(Console.ReadLine())/100;
            Console.WriteLine("For how many years would you like to save for?");
            double years = Convert.ToDouble(Console.ReadLine());
            double currentYear = years*12;
            double amountsaved = 0;
            for (int i = 1; i <= years*12; i++)
            {
                amountsaved += money * 4;
                amountsaved += amountsaved * rate;
                Console.WriteLine($"After {i} months in the year {years}, saved {amountsaved} ");

                if (currentYear % 12 == 0)
                {
                    currentYear++;
                }
            }
            Console.ReadKey();
        }
    }
}
