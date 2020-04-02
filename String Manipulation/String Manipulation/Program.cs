using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {           // postion  0123 
            string firstname = "CALE";
            string lastname = "REINKING";


            Console.WriteLine($"You have {firstname.Length.ToString("N0")} characters in your firstname.");
            Console.WriteLine($"You have {lastname.Length.ToString("N0")} characters in your lastname.");


            char FirstInitial = firstname[0];
            char LastInitial = lastname[0];

            //  Console.WriteLine(firstname.ToUpper()[0]);
            // Console.WriteLine(firstname.ToUpper()[1]);
            // Console.WriteLine(firstname.ToUpper()[2]);
            /// Console.WriteLine(firstname.ToUpper()[3]);  insteaddown

            firstname = firstname.ToUpper();
            // Foreach (char current Letter in firstname)


          //  for (int i = name.length-1; i >=  length; i--)
          //  {
            //    Console.WriteLine(name[i]);
           // }


            {
               // Console.WriteLine(CurrentLetter);
            }
            for (int i = 0; i < firstname.Length; i++)
            {
                //(i + 2) if you want to skip every other letter
                char currentLetter = firstname[i];
                Console.WriteLine(currentLetter);

            } //(int i = 0; i < length; i++);

            Console.WriteLine($"Your inititals are {FirstInitial}.{LastInitial}.");

            Console.ReadKey();
        }
    }
}
