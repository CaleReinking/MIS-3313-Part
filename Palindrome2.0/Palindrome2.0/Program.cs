using System;

namespace Palindrome2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phrase");
            string phrase = Console.ReadLine().ToLower();
            string backwards= "";
            
           int index = phrase.Length - 1;

            while (index>=0)
            {
                backwards += phrase[index];
                index--;
            }

            if (backwards == phrase)
            {
                Console.WriteLine("Palendrome");
            }

    else
	{
             Console.WriteLine("FAT NO");
	}
            Console.ReadKey();
        }
    }
}
