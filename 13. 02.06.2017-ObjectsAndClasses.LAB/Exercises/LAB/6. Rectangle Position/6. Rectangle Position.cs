namespace _6.Rectangle_Position
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Write a program to read two rectangles {left, top, width, height} 
    /// and print whether the first is inside the second.
    public class Program
    {
        public static void Main()
        {
            /// Calculate right, lesft, top and botom parameters of each rectangle
            double[] firstRectangle = ReadRectangle();
            double[] secondRectangle = ReadRectangle();

            /// Print result
            if (firstRectangle[0] >= secondRectangle[0] &&
                firstRectangle[1] <= secondRectangle[1] &&
                firstRectangle[2] >= secondRectangle[2] &&
                firstRectangle[3] <= secondRectangle[3])
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        public static double[] ReadRectangle()
        {
            double[] currRectangleArry = new double[4];

            double[] rectangleRead = Console.ReadLine()
               .Trim()
               .Split()
               .Select(double.Parse)
               .ToArray();

            var currRectangle = new Rectangle
            {
                Left = rectangleRead[0],
                Top = rectangleRead[1],
                Width = rectangleRead[2],
                Height = rectangleRead[3]
            };

            currRectangleArry[0] = currRectangle.Left;
            currRectangleArry[1] = currRectangle.Right;
            currRectangleArry[2] = currRectangle.Top;
            currRectangleArry[3] = currRectangle.Bottom;

            return currRectangleArry;
        }
    }
}
