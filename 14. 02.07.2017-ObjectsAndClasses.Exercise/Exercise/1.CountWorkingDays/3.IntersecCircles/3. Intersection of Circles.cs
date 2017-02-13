namespace _3.IntersecCircles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// Program that tells if two circles intersect.
    public class Program
    {
        public static void Main()
        {
            int[] firstCircle = ReadCircle();
            int[] secondCircle = ReadCircle();

            Circle firstCir = CurrCircle(firstCircle);
            Circle secondCir = CurrCircle(secondCircle);

            bool isIntersect = IsIntersect(firstCir, secondCir);

            /// Print result
            Console.WriteLine(isIntersect ? "Yes" : "No");
        }

        private static bool IsIntersect(Circle firstCir, Circle secondCir)
        {
            double diffX = firstCir.X - secondCir.X;
            double diffY = firstCir.Y - secondCir.Y;

            double distanse = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));

            if (distanse > firstCir.Radius + secondCir.Radius)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int[] ReadCircle()
        {
            int[] currentCircleInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            return currentCircleInfo;
        }

        public static Circle CurrCircle(int[] currCircle)
        {
            Circle currCircleInfo = new Circle
            {
                X = currCircle[0],
                Y = currCircle[1],
                Radius = currCircle[2]
            };

            return currCircleInfo;
        }
    }
}
