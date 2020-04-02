using System;

namespace Savings_Review_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much do you wanna save?");
            double money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("what int rate?");
            double rate = Convert.ToDouble(Console.ReadLine())/100;
            Console.WriteLine("How many years");
            double years = Convert.ToDouble(Console.ReadLine());
            double monthlyMoney =0;
            
            double time = years*12;
            for (int i = 1; i <= years*12; i++)
            {
                monthlyMoney += money * 4;
                monthlyMoney += (monthlyMoney * rate);
                Console.WriteLine($"After {i} months and {years} years you have {monthlyMoney.ToString("C2")}");

                if (time % 12 == 0)
                {
                    time++;
                }
            }

            Console.ReadKey();
        }
    }
}
