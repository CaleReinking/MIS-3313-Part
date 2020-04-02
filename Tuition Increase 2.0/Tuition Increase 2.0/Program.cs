using System;

namespace Tuition_Increase_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double tuition = 12000;
            double increase = .05;
            double newtuition;
            const double years = 7;
            for (int i = 1; i <= years; i++)
            {
                newtuition = (tuition + (tuition * increase));
                Console.WriteLine($"For year {i} your tuition is {newtuition.ToString("C0")}");
                tuition = newtuition;
            }
        }
    }
}
