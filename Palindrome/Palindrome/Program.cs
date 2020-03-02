using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word or statement >>");
            string statement = Console.ReadLine().ToLower();
            int index = statement.Length-1;
            string reverseStatement = "";
            while (index >= 0)
            {
                reverseStatement += statement[index];
                index--;
            }
            if (statement == reverseStatement)
            {
                Console.WriteLine($"Your word {statement} is a Palendrome ");
            }
            else
            {
                Console.WriteLine("Not a Palendrome!");
            }
        }
    }
}
