using System;

namespace DaysInAMonth_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a month");
            string inputMonth = Console.ReadLine().ToUpper();
            
          
            double daysinaMonth;

            if (inputMonth == "APRIL" || inputMonth == "JUNE" || inputMonth == "SEPTEMBER" || inputMonth == "NOVEMBER") 
            {
                daysinaMonth = 30;
            }
            else if (inputMonth == "FEBRUARY")
            {
                Console.WriteLine("Is it a leap year?");
                string answer = Console.ReadLine();
                answer.ToUpper();
                if (answer == "YES")
                {
                    daysinaMonth = 28;
                       
                }
                else
                {
                    daysinaMonth = 29;
                }

            }
            else
            {
                daysinaMonth = 31;
            }

            Console.WriteLine($"In the month of {inputMonth} there are {daysinaMonth}");
            Console.ReadKey();
        }
    }
}
