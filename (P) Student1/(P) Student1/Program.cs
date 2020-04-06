// Cale J Reinking, worked with Micah and Shelby 
using System;
using System.Collections.Generic;

namespace _P__Student1
{
    class Student1
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> CourseNames { get; set; }
        public List<string> CourseGrades { get; set; }

        public Student1()
        {
            FirstName = "";
            LastName = "";
            List<string> CourseNames = new List<string>();
            List<string> CourseGrades = new List<string>();

        }
        public Student1(string first, string second)
        {
            first = FirstName;
            second = LastName;
        }
        public double CalculateGPA()
        {
            double points = 0;
            double totalpoints = 0;

            foreach (var item in CourseGrades)
            {
                if (item == "A")
                {
                    points = 4 * 3;
                }
                else if (item == "B")
                {
                    points = 3 * 3;
                }
                else if (item == "C")
                {
                    points = 2 * 3;
                }
                else if (item == "D")
                {
                    points = 1 * 3;
                }
                else
                {
                    points = 0;
                }

                totalpoints += points;
            }
            return totalpoints / CourseGrades.Count;
        }
    }
}
