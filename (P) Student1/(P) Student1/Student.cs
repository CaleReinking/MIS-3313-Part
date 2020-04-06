using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Student1
{
    class Student
    {
        static void Main(string[] args)
        {
            Student1 stud1 = new Student1();
            stud1.FirstName = "Cale";
            stud1.LastName = "Reinking";
            stud1.CourseGrades.Add("A");
            stud1.CourseNames.Add("Programming by AA");
            stud1.CourseGrades.Add("B");
            stud1.CourseNames.Add("AAs harder programming class");
            stud1.CalculateGPA();

            Console.ReadKey();
        }
    }
}
