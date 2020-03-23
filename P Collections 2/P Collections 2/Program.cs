using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Collections_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            string[] names = new string[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please enter your course name>>");
                names[i] = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Please enter your course number >>");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < numbers.Length; i++)
            {

                Console.WriteLine($"{names[i].ToUpper()}{ numbers[i]}");
            }

            List<int> grades = new List<int>();
            string answer = "";
            

            
            do
            {
                Console.WriteLine("Enter your exam score");
                grades.Add(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Do you have another exam grade to enter?");
                answer = Console.ReadLine().ToLower();

            } while (answer == "yes");

            double sum = 0;
           double minimum = 100;
            double maximum = 0;

            foreach (var grade in grades)
            {
                sum = sum + grade;

                if (grade < minimum)
                {
                    minimum = grade;
                }

                if (grade > maximum)
                {
                    maximum = grade;
                }

                Console.WriteLine($"Your max is{maximum} and your minimum is {minimum}");

            }




         }   
        
    }
}
