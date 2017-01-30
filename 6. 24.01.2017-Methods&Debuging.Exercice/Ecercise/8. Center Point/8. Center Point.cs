namespace _8.Center_Point
{
    using System;

    /// Print the closest point to the center (0,0)
    public class Program
    {
        public static void Main(string[] args)
        {
            double firstPointX = double.Parse(Console.ReadLine());
            double firstPointY = double.Parse(Console.ReadLine());
            double secondPointX = double.Parse(Console.ReadLine());
            double secondPointY = double.Parse(Console.ReadLine());
            FirstPointToCenterDist(firstPointX, firstPointY);
            SecondPointToCenterDist(secondPointX, secondPointY);
            CompareDistance(FirstPointToCenterDist(firstPointX, firstPointY), SecondPointToCenterDist(secondPointX, secondPointY));

            if (CompareDistance(FirstPointToCenterDist(firstPointX, firstPointY), SecondPointToCenterDist(secondPointX, secondPointY)) == true)
            {
                Console.WriteLine($"({secondPointX}, {secondPointY})");
            }
            else
            {
                Console.WriteLine($"({firstPointX}, {firstPointY})");
            }
        }

        public static double FirstPointToCenterDist(double firstPoint, double secondPoint)
        {
            double firstPointToCenterDist = Math.Sqrt((firstPoint * firstPoint) + (secondPoint * secondPoint));
            return firstPointToCenterDist;
        }

        public static double SecondPointToCenterDist(double firstPoint, double secondPoint)
        {
            double secondPointToCenterDist = Math.Sqrt((firstPoint * firstPoint) + (secondPoint * secondPoint));
            return secondPointToCenterDist;
        }

        public static bool CompareDistance(double firstPointToCenterDistance, double secondPointToCenterDistance)
        {
            bool isSecondPointDistanceLess = false;
            if (firstPointToCenterDistance <= secondPointToCenterDistance)
            {
                isSecondPointDistanceLess = false;
            }
            else
            {
                isSecondPointDistanceLess = true;
            }

            return isSecondPointDistanceLess;
        }
    }
}
