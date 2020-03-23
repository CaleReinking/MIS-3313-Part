using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss_3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int randomNumber = rand.Next(0, 2);
            Console.WriteLine(randomNumber);
            Console.WriteLine("Enter Heads or Tails >>");
            string UserInputasString = Console.ReadLine();
            int UserInput;
            HeadsValue = 0;
            TailsValue = 1;


            if (UserInputasString == "Heads")
            {
                UserInput = HeadsValue;
            }
            else if
            {
                UserInput = TailsValue;
            }
            else
            {
                Console.WriteLine("Invalid Entry, please try again");
                Console.ReadKey();
                return;
            }

            if (UserInput == randomNumber)
            {
                Console.WriteLine($"Congrats, {UserInputasString} is correct!");
            }
            else
            {
                if (UserInput == 0)
                {
                    Console.WriteLine($"Sorry, tails was the correct answer and you guessed {UserInputasString}")
                }
                else
                {
                    Console.WriteLine($"You guessed heads and the correct answer was {UserInputasString}");
                }
            }





            Console.ReadKey();
        }
    }
}
