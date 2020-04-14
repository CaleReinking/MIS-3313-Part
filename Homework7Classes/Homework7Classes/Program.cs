using System;
using System.Collections.Generic;
//Cale J Reinking, worked with Derek Smith, Ben Henke and Meri Santonomero

namespace Homework7Classes
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudenID { get; set; }
        public List <double> ExamGrades { get; set; } //Attribute List for exam grades
        public List<double> FinalExamGrades { get; set; }
        public List<double> HomeworkGrades { get; set; }
        public List<double> ParticipationGrades { get; set; }
        public List<double> QuizGrades { get; set; }

        public Student() // Constructor: Gives all of the attributes above a value
        {
            FirstName = "";
            LastName = "";
            StudenID = 0;
            ExamGrades = new List<double>();
            FinalExamGrades = new List<double>();
            HomeworkGrades = new List<double>();
            ParticipationGrades = new List<double>();
            QuizGrades = new List<double>();
        }
        public Student(int studentId)
        {
            StudenID = studentId;
        }
        public Student(string firstname, string lastname, int studentID)
        {
            FirstName = firstname;
            LastName = lastname;
            StudenID = studentID; //This is for the Console.WriteLine(Stud1) on the other page 
            //Set the names equal and in the method below, you write out the correct output
        }
        public override string ToString()
        {
            return LastName + "," + FirstName + "(" + StudenID + ")"; // This is what writes out their info
        }
        public double CalculateExamAverage()
        {
            double avg = 0;
            foreach (double score in ExamGrades)
            {
                avg += score;
            }
            avg /= ExamGrades.Count;
            return avg;
        }
        public double CalculateFinalExamAverage()
        {
            double avg = 0;
            foreach (double score in FinalExamGrades)
            {
                avg += score;
            }
            avg /= FinalExamGrades.Count;
            return avg;
        }
        public double CalculateHomeworkAverage()
        {
            double avg = 0;
            foreach (double score in HomeworkGrades)
            {
                avg += score;
            }
            avg /= HomeworkGrades.Count;
            return avg;
        }
        public double CalculateParticipationAverage()
        {
            double avg = 0;
            foreach (double score in ParticipationGrades)
            {
                avg += score;
            }
            avg /= ParticipationGrades.Count;
            return avg;
        }
        public double CalculateQuizAverage()
        {
            double avg = 0;
            foreach (double score in QuizGrades)
            {
                avg += score;
            }
            avg /= QuizGrades.Count;
            return avg;
        }
    }
}
