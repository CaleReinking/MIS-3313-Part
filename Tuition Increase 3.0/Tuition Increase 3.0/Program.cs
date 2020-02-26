using System;

namespace Tuition_Increase_3._0
{
    class Program
    {
        static void Main(string[] args)
        {
           double tuition = 12000;
            double rate = .05;
            double year = 7;
            for (int i = 1; i < year+1; i++)
            {
                 tuition += tuition * rate;
                Console.WriteLine($"In year {i} your tuition will be {tuition.ToString("C2")}");
                   

            }
        }
    }
}
