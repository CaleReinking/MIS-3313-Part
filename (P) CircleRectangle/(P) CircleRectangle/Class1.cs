using System;
using System.Collections.Generic;
using System.Text;

namespace _P__CircleRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.Length = 8;
            rect1.Width = 6;

            Rectangle rect2 = new Rectangle();
            rect2.Length = 10;
            rect2.Width = 6;

            Console.WriteLine($"The length of your first rectange is {rect1.Length} and the width is {rect1.Width} The area is {rect1.Area()} and the perimeter is {rect1.Perimeter()}.");
            Console.WriteLine($"The length of your second rectange is {rect2.Length} and the width is {rect2.Width} The area is {rect2.Area()} and the perimeter is {rect2.Perimeter()}.");

            Console.ReadKey();
        }
    }
}
