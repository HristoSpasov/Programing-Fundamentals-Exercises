﻿namespace _6.Rectangle_Position
{
    public class Rectangle
    {
        public double Left { get; set; }

        public double Top { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Bottom => Top + Height;

        public double Right => Left + Width;
    }
}
