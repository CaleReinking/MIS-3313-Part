using System;

namespace Palindrome3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter phrase");
            string phrase = Console.ReadLine().ToLower();
            int index = phrase.Length - 1;
            string backwards = "";

            while (index>=0)
            {
               backwards+= phrase[index];
                index--;
            }
            if (backwards == phrase)
            {
                Console.WriteLine("Palindrome");

            }

            else
            {
                Console.WriteLine("nope");
            }


            Console.ReadKey();
        }
    }
}
