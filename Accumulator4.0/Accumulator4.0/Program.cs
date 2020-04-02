using System;

namespace Accumulator4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double multiply = 1;

            for (int i = 1; i < 101; i++)
            {
                sum += i;
                multiply *= i;


            }
            Console.WriteLine($"sum is {sum}");
            Console.WriteLine($"mullet is {multiply}");
        }
    }
}
