using System;

namespace _P__Simple_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose an animal, snake, cow, horse, or pig>>");
            string animal = Console.ReadLine().ToLower();
            
            string Noise = speak(animal);
            Console.WriteLine(Noise);

            Console.ReadKey();
        }
        static string speak(string animal)
        {
            string noise;
            if (animal == "snake")
            {
                noise = "hiss";
            }
            else if (animal == "cow")
            {
                noise = "moo";
            }
            else if (animal == "horse")
            {
                noise = "nay";
            }
            else if (animal == "pig")
            {
                noise = "oink";
            }
            else
            {
                noise = "crazy noise";
            }
            return noise;
        }
    }
}
