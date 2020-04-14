using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7Classes
{
    class Class1
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student();
            stud1.FirstName = "Ben";
            stud1.LastName = "Henke";
            stud1.StudenID = 1800;
            stud1.ExamGrades = new List<double>() { 90, 90, 100, 90, 90 };
            stud1.FinalExamGrades = new List<double>() { 90, 10, 52, 33, 10 };
            stud1.HomeworkGrades = new List<double>() { 90, 69, 79, 99, 59 };
            stud1.ParticipationGrades = new List<double>() { 10, 95, 10, 95, 10 };
            stud1.QuizGrades = new List<double>() { 97, 95, 90, 65, 75 };
           
            Console.WriteLine(stud1);
            Console.WriteLine("Exam Average is {0}", stud1.CalculateExamAverage());
            Console.WriteLine("Final Exam Average is {0}", stud1.CalculateFinalExamAverage());
            Console.WriteLine("Homework Average is {0}", stud1.CalculateHomeworkAverage());
            Console.WriteLine("Participation Average is {0}", stud1.CalculateParticipationAverage());
            Console.WriteLine("Quiz Average is {0}", stud1.CalculateQuizAverage());
            Console.WriteLine();

            Student stud2 = new Student();
            stud2.FirstName = "Cale";
            stud2.LastName = "Reinking";
            stud2.StudenID = 1801;
            stud2.ExamGrades = new List<double>() { 99, 91, 100, 99, 99 };
            stud2.FinalExamGrades = new List<double>() { 99, 100, 52, 33, 100 };
            stud2.HomeworkGrades = new List<double>() { 99, 79, 69, 59, 49 };
            stud2.ParticipationGrades = new List<double>() { 100, 90, 100, 90, 100 };
            stud2.QuizGrades = new List<double>() { 87, 95, 100, 75, 65 };

            Console.WriteLine(stud2);
            Console.WriteLine("Exam Average is {0}", stud2.CalculateExamAverage());
            Console.WriteLine("Final Exam Average is {0}", stud2.CalculateFinalExamAverage());
            Console.WriteLine("Homework Average is {0}", stud2.CalculateHomeworkAverage());
            Console.WriteLine("Participation Average is {0}", stud2.CalculateParticipationAverage());
            Console.WriteLine("Quiz Average is {0}", stud2.CalculateQuizAverage());
            Console.WriteLine();

            Student stud3 = new Student();
            stud3.FirstName = "Meri";
            stud3.LastName = "Santonomero";
            stud3.StudenID = 1802;
            stud3.ExamGrades = new List<double>() { 90, 97, 90, 90, 90 };
            stud3.FinalExamGrades = new List<double>() { 90, 100, 52, 93, 100 };
            stud3.HomeworkGrades = new List<double>() { 97, 69, 69, 50, 99 };
            stud3.ParticipationGrades = new List<double>() { 24, 90, 10, 90, 10 };
            stud3.QuizGrades = new List<double>() { 97, 95, 98, 75, 98 };

            Console.WriteLine(stud3);
            Console.WriteLine("Exam Average is {0}", stud3.CalculateExamAverage());
            Console.WriteLine("Final Exam Average is {0}", stud3.CalculateFinalExamAverage());
            Console.WriteLine("Homework Average is {0}", stud3.CalculateHomeworkAverage());
            Console.WriteLine("Participation Average is {0}", stud3.CalculateParticipationAverage());
            Console.WriteLine("Quiz Average is {0}", stud3.CalculateQuizAverage());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
