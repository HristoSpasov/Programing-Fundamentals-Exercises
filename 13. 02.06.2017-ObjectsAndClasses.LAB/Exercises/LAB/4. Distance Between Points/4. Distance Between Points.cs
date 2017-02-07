namespace _4.Distance_Between_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Calculate the distance between two points 
    /// p1 {x1, y1} and p2 {x2, y2}. Write a program 
    /// to read two points (given as two integers) and
    /// print the Euclidean distance between them.
    public class Program
    {
        public static void Main()
        {
            double[] point = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var firstPoint = new PointsAdd
            {
                PointX = point[0],
                PointY = point[1]
            };

            point = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var secondPoint = new PointsAdd
            {
                PointX = point[0],
                PointY = point[1]
            };

            double result = CalculateDistanse(firstPoint, secondPoint);

            Console.WriteLine($"{result:F3}");
        }

        public static double CalculateDistanse(PointsAdd firstPoint, PointsAdd secondPoint)
        {
            double diffXaxis = firstPoint.PointX - secondPoint.PointX;
            double diffYaxis = firstPoint.PointY - secondPoint.PointY;
            double result = Math.Sqrt(Math.Pow(diffXaxis, 2) + Math.Pow(diffYaxis, 2));

            return result;
        }
    }
}
