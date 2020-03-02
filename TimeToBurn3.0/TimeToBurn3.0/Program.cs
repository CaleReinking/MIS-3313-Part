using System;

namespace TimeToBurn3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many calories would you like to burn this workout?");
            double calories = Convert.ToDouble(Console.ReadLine());
            const double rate = 3.9;

            double minutes = calories / rate;
            double caloriesburned = 0;
            for (int i = 0; i <= minutes; i++)
            {
                caloriesburned = (i * 3.9);
                Console.WriteLine($"After minute {i} you have burnt {caloriesburned}");
            }

        }
    }
}
