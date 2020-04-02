using System;

namespace Doodle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write your fav word");
            string funny = Console.ReadLine().ToLower();

           int funniest = funny.Length;

            Console.WriteLine(funny[0]);

            Console.ReadKey();

        }
    }
}
