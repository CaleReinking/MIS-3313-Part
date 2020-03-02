using System;

namespace Palindrome2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phrase");
            string phrase = Console.ReadLine().ToLower();
            int index = phrase.Length-1;
            string reversePhrase = "";

            while (index>=0)
            {
                reversePhrase += phrase[index];
                index--;
            }
            if (phrase==reversePhrase)
            {
                Console.WriteLine($"Your phrase {phrase} is a palendrome");
            }
            else
            {
                Console.WriteLine("Not a palendrome");
            }
        }
    }
}
