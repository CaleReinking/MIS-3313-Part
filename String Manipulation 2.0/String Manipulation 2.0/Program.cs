using System;

namespace String_Manipulation_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(sentence);

            Console.WriteLine("What word are you looking for in this statement?");
            string lookWord = Console.ReadLine();

            Console.WriteLine("What word do you want to replace it with?");
            string replaceWord = Console.ReadLine();
            
            if (sentence.Contains(lookWord))
            {
                string newSentence = sentence.Replace(lookWord, replaceWord);
                Console.WriteLine(newSentence);
            }
            else
            {
                Console.WriteLine($"Sorry, I could not find your word {lookWord}");
                for (int i = 0; i > replaceWord.Length - 1; i--)
                {
                    Console.WriteLine(replaceWord[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
