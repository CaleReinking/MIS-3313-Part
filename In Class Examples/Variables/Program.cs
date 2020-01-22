//Cale Reinking 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a string named firstName
            string firstName;

            //Assign a value to firstName Cale 
            firstName = "Cale";


            //Create an int named favoriteNumber and assign your fav num to it 
            int favoriteNumber = 8;

            double crazyNumber = 7.64732846 * favoriteNumber;

            string lastName = "Reinking";
            string fullName = firstName + "" + lastName;


            Console.WriteLine(fullName + "has the favorite number of" + favoriteNumber
                + "Which equates to a crazy number" + crazyNumber);


            // Make it Dynamic 
            Console.WriteLine("Please enter your first name: >>");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:  >>");
           lastName= Console.ReadLine();
            Console.WriteLine("Please enter your fav number: >>");
           favoriteNumber= Console.ReadLine();
            string fullName = firstName + "" + lastName;
            Console.WriteLine(fullName + "has the favorite number of" + favoriteNumber
               + "Which equates to a crazy number" + crazyNumber);

            Console.ReadKey();
        }
    }
}
