//Cale Reinking 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your First Name: ");
            string firstName = Console.ReadLine();

            string favNumberasString = Console.ReadLine();
            Console.WriteLine("Please Enter Your Favorite Number");
            int favNum = Convert.ToInt32(Console.ReadLine());

            int favNumberTimes10 = 10 * favNum;

            string message = firstName + " " + "you have favorite number of" + favNum + "and if you mulitply that by 10 you get" + favNumberTimes10.ToString("N3");

            if (favNum == 7 || favNum== 3)
            {
                Console.WriteLine("How original are you?");
            }

            if(favNum==13)
            {
                Console.WriteLine("Are you kidding me???");
            }

            if(favNum % 2 ==0)
            {
                Console.WriteLine("Your Number is Even");

            }
            else
            {
                Console.WriteLine("Your Number is Odd");
            }
            Console.WriteLine (message);
            Console.ReadKey();


        }
    }
}
