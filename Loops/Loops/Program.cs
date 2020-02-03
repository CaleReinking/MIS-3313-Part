using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("What number do you want to count to?");
            int threshold = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= threshold; i++)
            {
                Console.Write (i + " ");

            }
            Console.ReadKey();

            double sum = 0;
            string answer;

                do
            {
                Console.WriteLine("Please give us a number to add to");
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;


            } while (true);
           

            Console.ReadKey();
        }

    }
}
