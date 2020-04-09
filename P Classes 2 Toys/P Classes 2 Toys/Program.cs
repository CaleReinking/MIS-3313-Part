using System;
// Collaborated with Meri and Ben
namespace P_Classes_2_Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy Toy1 = new Toy();

            Toy1.Manufacturer = "Lego";
            Toy1.Name = "Lego Fan";
            Toy1.Price = 9.99;
            Toy1.GetAisle();
            Toy1.GetAisle2();

            Console.WriteLine($"The toy manufacturer is {Toy1.Manufacturer}.");
            Console.WriteLine($"The toy name is {Toy1.Name}.");
            Console.WriteLine($"The price of the toy is {Toy1.Price}.");
            Console.WriteLine($"The toy is located at aisle {Toy1.GetAisle()} {Toy1.GetAisle2()}.");

            Console.ReadKey
        }
    }
}
