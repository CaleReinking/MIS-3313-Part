using System;
using System.Collections.Generic;
using System.Text;

namespace CircleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle2 cir1 = new Circle2();
            cir1.radius = 9;

            Circle2 cir2 = new Circle2();
            cir2.radius = 5;

            Console.WriteLine($"The radius of your circle is {cir1.radius}. and a area of {cir1.Area()} and a perimeter of {cir1.Perimeter()}.");

            Console.WriteLine($"The radius of your circle is {cir2.radius}. and a area of {cir2.Area()} and a perimeter of {cir2.Perimeter()}.");
        }
    }
}
