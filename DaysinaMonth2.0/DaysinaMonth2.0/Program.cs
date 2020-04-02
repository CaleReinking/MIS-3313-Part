using System;

namespace DaysinaMonth2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which month do you want to know the number of days for?");
            string answer = Console.ReadLine().ToLower();
            double days;

            if (answer == "april" || answer == "june" || answer == "september" || answer == "november")
            {
                days = 30;
            }
            else if (answer == "february")
            {
                Console.WriteLine("Is it a leap year? y or n");
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    days = 29;
                }
                else
                {
                    days = 28;
                }
            }
            else
            {
                days = 31;
            }
                Console.WriteLine($"The number of days in {answer} is {days}");
                Console.ReadKey();
            }
            

        }
    }

