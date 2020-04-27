using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your food dictionary! Lets add a category!");
            //string category;
            string response = "";
            string response2 = "";

            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> FoodDictionary = dictionary;

                do
            {
                string newcateogry = "";
                string category = "";
                string food = "";

                Console.WriteLine("Are you entering a category or adding another food item? Enter either cateogry or food");
                if (response2 == "category")
                {
                    Console.WriteLine("What is the name of the food cateogry?");
                    newcateogry = Console.ReadLine();
                    FoodDictionary.Add(newcateogry, new List<string>());
                }
                else if (response2 == "food")
                {
                    Console.WriteLine("What category would you like to add the food to?");
                    category = Console.ReadLine();
                    if (FoodDictionary.ContainsKey(category))
                    {
                        Console.WriteLine($"What food would you like to add do {category}");
                        food = Console.ReadLine();
                        List<string> list = FoodDictionary[category];
                        list.Add(food);
                    }
                    else
                    {
                        Console.WriteLine("That category does not exist");
                    }
                }

            } while (response == "yes");
        }
    }
}
