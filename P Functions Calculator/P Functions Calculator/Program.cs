using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Functions_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            double result = 0;
            double first =0;
            bool shouldaskforfirst = true;
            do
            {
                Console.WriteLine("What function do you wish to use?");
                string type = Console.ReadLine().ToLower();

                if (shouldaskforfirst == true)
                {
                    Console.WriteLine("Enter your first value >>");
                    first = Convert.ToDouble(Console.ReadLine());
                }
                

                Console.WriteLine("enter your second value >>");
                double second = Convert.ToDouble(Console.ReadLine());

                if (type == "add")
                {
                   result = Add(first, second);
                   
                }
                else if (type == "subtract")
                {
                    result = Subtract(first, second);
                  
                }
                else if (type == "multiply")
                {
                    result = Multiply(first, second);
                   
                }
                else if (type == "divide")
                {
                    result = Divide(first, second);
                }
                else
                {
                    Console.WriteLine("Error");
                }
                Console.WriteLine(result);

                Console.WriteLine("Do you have another function you wish to run?");
              answer = Console.ReadLine().ToLower();
                string answer2 = "";
                if (answer == "yes")
                {
                    Console.WriteLine("Do you want to reuse your result as the first number?");
                     answer2 = Console.ReadLine().ToLower();
                }
                

                if (answer2 == "yes")
                {
                    answer = "yes";
                   first = result;
                    shouldaskforfirst = false;
                }
                else
                {
                    shouldaskforfirst = true;
                    answer = "no";
                }
              
            } while (answer == "yes");



        }

        static double Add(double first, double second)

        {

            return first + second;
        }

        static double Subtract(double first, double second)
        {
            return first - second;
        }
        static double Multiply(double first, double second)
        {
            return first*second;
        }
        static double Divide(double first, double second)
        {
            return first/second;
        }
        static void DeveloperInformation(string developerName, string className, string dateofWriting)
        {
            Console.WriteLine($"{developerName} wrote this in {className} on the day of {dateofWriting}");
        }
    }
}
