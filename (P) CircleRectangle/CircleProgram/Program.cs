using System;

namespace CircleProgram
{
    class Circle2
    {
        public double radius { get; set; }
        public Circle2 ()
        {
            radius = 0;
        }
        public double Area()
        {
            return Math.PI * radius;
        }
        public double Perimeter()
        {
            return (2 * Math.PI) * radius;
        }
    }
}
