namespace _5.Closest_Two_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Program to read n points and find the closest two of them.
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n]; /// Array to store points

            /// Read all points and fill points array
            for (int i = 0; i < n; i++)
            {
                double[] currPointSplit = Console.ReadLine()
                    .Trim()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();

                var currPoint = new Point
                {
                    X = currPointSplit[0],
                    Y = currPointSplit[1]
                };

                points[i] = currPoint;
            }

            double minDistance = int.MaxValue;
            Point firstPointMin = null;
            Point secondPointMin = null;

            /// Compare distanse between each unique pair of points
            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    Point firstPoint = points[i];
                    Point secondPoint = points[j];

                    double currResultDist = CalculateDistanse(firstPoint, secondPoint);

                    if (currResultDist < minDistance)
                    {
                        minDistance = currResultDist;
                        firstPointMin = firstPoint;
                        secondPointMin = secondPoint;
                    }
                }
            }

            /// Peint min distanse and both points coordinates
            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine($"({firstPointMin.X}, {firstPointMin.Y})");
            Console.WriteLine($"({secondPointMin.X}, {secondPointMin.Y})");
        }

        /// Calculate distanse
        public static double CalculateDistanse(Point firstPoint, Point secondPoint)
        {
            double diffX = firstPoint.X - secondPoint.X;
            double diffY = firstPoint.Y - secondPoint.Y;
            double resultDist = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));

            return resultDist;
        }
    }
}
