using System;

namespace Tutor_3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double val1;
            double val2;
            Random rand = new Random();
            val1 = rand.Next(0, 50);
            val2 = rand.Next(0, 50);
            double sum;
            sum = (val1 + val2);

            double answer = 0;
            

            while (answer != sum)
            {
                Console.WriteLine($"Whatis {val1} + {val2} = ?");
                double userGuess = Convert.ToDouble(Console.ReadLine());
                if (userGuess == sum)
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Wrong, try again");
                   
                }
                answer = userGuess;
            }
        }
    }
}
