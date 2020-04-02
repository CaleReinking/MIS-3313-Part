using System;

namespace Tutor_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int rand1 = rand.Next(1, 50);
            int rand2 = rand.Next(1, 50);
            int sum = (rand1 + rand2);

            int answer;
            do
            {
                Console.WriteLine($"What is the sum of {rand1} + {rand2}?");
                int userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess == sum)
                {
                    Console.WriteLine("You are correct");
                }
                else
                {
                    Console.WriteLine("Please try again");
                    
                }
                answer = userGuess;
            } while (sum != answer);

            Console.ReadKey();

        }
    }
}
