using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Class_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Heads or Tails >>");
            string userGuessAsString = Console.ReadLine();

            int userGuess;

            if (userGuessAsString == "Heads")
            {
                userGuess = 'Heads';
            }
            else
            {
                userGuess = 2 ;

                    }
            Random rand = new Random();

            int randomNumber = rand.Next(1, 2);


           




              Console.ReadKey();

        }
    }
}
