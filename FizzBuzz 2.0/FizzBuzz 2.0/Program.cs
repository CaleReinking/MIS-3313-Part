using System;

namespace FizzBuzz_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lucky number here");
            string luckyNumber = Console.ReadLine();
            bool number = (Int32.TryParse(luckyNumber, out int luckyNumbernumber));

            if (number == false)
            {
                Console.WriteLine("unable to run the FizzBuzz process due to the input not being a valid number.");
            }
            else if (luckyNumbernumber % 3 == 0 && luckyNumbernumber % 5 ==0)
            {
                Console.WriteLine($"{luckyNumbernumber} FizzBuzz");
            }
            else if (luckyNumbernumber % 3 == 0)
            {
                Console.WriteLine($"{luckyNumbernumber} Fizz");
            }
            else if (luckyNumbernumber % 5 == 0)
            {
                Console.WriteLine($"{luckyNumbernumber} Buzz");
            }
            else
            {
                Console.WriteLine(luckyNumbernumber);

            }
            Console.ReadKey();
        }
    }
}
