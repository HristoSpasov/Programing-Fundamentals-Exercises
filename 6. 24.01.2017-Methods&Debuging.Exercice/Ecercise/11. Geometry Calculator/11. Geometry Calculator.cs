namespace _11.Geometry_Calculator
{
    using System;

    /// Calculate area of triangle/square/rectangle/circle
    /// based on figure type input
    public class Program
    {
        public static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            /// Forward to specific method according to figure selection
            if (figureType == "triangle")
            {
                ReturnTriangleArea();
            }
            else if (figureType == "square")
            {
                ReturnSquareArea();
            }
            else if (figureType == "rectangle")
            {
                ReturnRectangleArea();
            }
            else
            {
                ReturnCircleArea();
            }
        }

        /// Triangle area
        public static void ReturnTriangleArea()
        {
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double trinagleArea = triangleSide * triangleHeight / 2;

            Console.WriteLine("{0:F2}", trinagleArea);
        }

        /// Square area
        public static void ReturnSquareArea()
        {
            double squareSide = double.Parse(Console.ReadLine());
            double squareArea = squareSide * squareSide;

            Console.WriteLine("{0:F2}", squareArea);
        }

        /// Rectangle area
        public static void ReturnRectangleArea()
        {
            double rectangleSideA = double.Parse(Console.ReadLine());
            double rectangleSideB = double.Parse(Console.ReadLine());
            double rectangleArea = rectangleSideA * rectangleSideB;

            Console.WriteLine("{0:F2}", rectangleArea);
        }

        /// Circle area
        public static void ReturnCircleArea()
        {
            double circleRadius = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * circleRadius * circleRadius;

            Console.WriteLine("{0:F2}", circleArea);
        }
    }
}
