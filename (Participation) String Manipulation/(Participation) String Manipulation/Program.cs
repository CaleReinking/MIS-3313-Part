// Cale Reinking
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Participation__String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string funny=("Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.");
            Console.WriteLine(funny);

            Console.WriteLine("what word do you want to look for in the above sentence");
            string place =Console.ReadLine();
            string backwards = place;


            if (funny.Contains(place))
            {
                Console.WriteLine("what word do you want to change it to?");
                string answer = Console.ReadLine();
               string newsentence = funny.Replace(place, answer);
                Console.WriteLine(newsentence);
            }
            else
            {
                Console.WriteLine($"Sorry, I could not find your word {place} ");
                int index = place.Length - 1;
                backwards += place[index];
                index++;
                Console.WriteLine(backwards);


            }



            Console.ReadKey();
        }


    }
}
