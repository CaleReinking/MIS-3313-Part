using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Functions_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which participation fo you want to run? fizzbuzz or converter");
            string participation = Console.ReadLine().ToLower();
            string Fizzbuzz = "";
            string converter = "";

            if (participation == "fizzbuzz")
            {
                Fizzbuzz;
            }
            if (participation == "converter")
            {
                converter;
            }
        }
        static void Fizzbuzz(string luckynumber)
        {
            Console.WriteLine("Enter lucky number here");
            string luckyNumber = Console.ReadLine();
            bool number = (Int32.TryParse(luckyNumber, out int luckyNumbernumber));

            if (number == false)
            {
                Console.WriteLine("unable to run the FizzBuzz process due to the input not being a valid number.");
            }
            else if (luckyNumbernumber % 3 == 0 && luckyNumbernumber % 5 == 0)
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

          
        }
        static void converter(string sentence)
        {

            Console.WriteLine("Please input a sentence");
            string sentence = Console.ReadLine().ToUpper();

            sentence = sentence.Replace('A', '@');
            sentence = sentence.Replace('E', '3');
            sentence = sentence.Replace("H", "|-|");
            sentence = sentence.Replace('S', '$');
            sentence = sentence.Replace('T', '7');
            sentence = sentence.Replace("U", "|_|");

            char last = sentence[sentence.Length - 1];
            if (last != '!')
            {
                Console.WriteLine($"{sentence}!");
            }
            else
            {
                Console.WriteLine(sentence);
            }
            Console.ReadKey();
        }
    }
}
