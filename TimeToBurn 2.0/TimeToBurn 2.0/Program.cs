using System;

namespace TimeToBurn_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double calories;
            Console.WriteLine("How many calories do you wish to burn?");
            calories = Convert.ToDouble(Console.ReadLine());

            double caloriestoburn = 3.7;
          double caloriesburned = 0;
            int minute = 1;
            while (calories>caloriesburned)
            {
                caloriesburned = (minute * caloriestoburn);
                Console.WriteLine($"After minute {minute} you have burnt {caloriesburned} .");
                minute += 1;
            }
            Console.ReadKey();
           
        }
    }
}
