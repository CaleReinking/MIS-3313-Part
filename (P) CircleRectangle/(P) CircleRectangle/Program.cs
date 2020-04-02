using System;

namespace _P__CircleRectangle
{
    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle ()
        {
            Length = 0;
            Width = 0;

        }
            public double Area ()
        {
            return Length * Width;
        }
        public double Perimeter ()
        {
            return 2 * (Length + Width);
        }
    }
}
