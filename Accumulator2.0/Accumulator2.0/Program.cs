using System;

namespace Accumulator2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double multiplier = 1;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
                multiplier *= i;
            }
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"and multiplied is {multiplier.ToString("N0")}");
        }
    }
}
