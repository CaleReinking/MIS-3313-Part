using System;

namespace Homework_1_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastname;
            double id;
            double participation;
            double homework;
            double quizzes;
            double midterm;
            double final;
            double finalgrade;

            Console.WriteLine("What is your first name?");
            firstName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("What is your last name?");
            lastname = Convert.ToString(Console.ReadLine());

            Console.WriteLine("what is your student id?");
            id = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what is your overall percentage grade for homework?");
            homework = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what is your overall percentage grade for participation?");
            participation = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what is your overall percentage grade for quizzes?");
            quizzes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what is your overall percentage grade for midterm?");
            midterm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what is your overall percentage grade for final?");
            final = Convert.ToDouble(Console.ReadLine());

            finalgrade = (homework * .2) + (participation * .1) + (quizzes * .1) + (midterm * .3) + (final * .3);
            Console.WriteLine($"{firstName} {lastname} with ID number {id} your final grade is {finalgrade.ToString("P2")}");

            Console.ReadKey();

        }
    }
}
