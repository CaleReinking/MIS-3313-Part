using System;

namespace Homework_1_3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            const double salesTax = .085;
            string itemName;
            double itemPrice;
            double itemQuantity;
            double subtotal;
            double taxAmt;
            double totalPrice;

            Console.WriteLine("What item are you buying?");
            itemName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("What is that items price?");
            itemPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What quantity are you purchasing?");
            itemQuantity = Convert.ToDouble(Console.ReadLine());

            subtotal = (itemPrice * itemQuantity);
            taxAmt = (salesTax * subtotal);
            totalPrice = (taxAmt + subtotal);

            Console.WriteLine($"When subtotal is {subtotal} that has a sales tax of {taxAmt} and a sale total of {totalPrice}");

            Console.ReadKey();

        }
    }
}
