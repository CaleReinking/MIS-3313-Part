using System;

namespace Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many names of students would you like to store?");
            int namelength = Convert.ToInt32(Console.ReadLine());

            string[] firstname = new string[namelength];
            string[] lastname = new string[namelength];

            for (int i = 0; i < namelength; i++)
            {
                Console.WriteLine($"Please enter the first name for student #{i + 1}");
                string firstnames = Console.ReadLine();
                firstname[i] = firstnames;

                Console.WriteLine($"Please enter the last name for student #{i + 1}");
                string lastnames = Console.ReadLine();
                lastname[i] = lastnames;
            }
            int index = 0;
            while (index < namelength)
            {
                Console.WriteLine($"{lastname[index]}, {firstname[index]}");
                index++;

            }
            Console.ReadKey();
        }
    }
}
