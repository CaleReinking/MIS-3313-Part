using System;

namespace Converter_3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence yo");
            string sentence = Console.ReadLine().ToUpper();

            sentence = sentence.Replace('A', '@');
            sentence = sentence.Replace('E', '3');
            sentence = sentence.Replace("H", "|-|");
            sentence = sentence.Replace('S', '$');
            sentence = sentence.Replace('T', '7');
            sentence = sentence.Replace("U", "|_|");
            
            char last = sentence[sentence.Length - 1];

            if (last == '!')
            {
                Console.WriteLine(sentence);
            }
            else
            {
                Console.WriteLine($"{sentence}!");
            }

        }
    }
}
