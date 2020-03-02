using System;

namespace VowelsandConsonants_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence");
            string sentence = Console.ReadLine().ToLower();

            int vowels = 0;
            int consonants = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if ("aeiou" == sentence)
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }

            }
           /* foreach (char letter in sentence.ToLower())
            {
                if ("aeiou".Contains(letter))
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }

                */
            
            Console.WriteLine($"There were {vowels} vowels and {consonants} consonants");
            Console.ReadKey();
        }
    }
}
