using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Class_P_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "";
            do
            {
                Console.WriteLine("Enter your exam grade");
                double examGrade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Do you want to enter another grade?");
                response = Console.ReadLine();

                List<double> TotalGrade = new List<double>();
                TotalGrade.Add(examGrade);
            } while (response == "yes");
            double max = 100;
           double min = -1;
            for (int i = 0; i < TotalGrade; i++)
            { Sum = SUM + [i]

            }
          


          //  eGrade.Add(ExamGrade);
           // eGrade.Add(eGrade);
           // eGrade.Add(eGrade);
          
            Console.ReadKey();
        }
    }
}
