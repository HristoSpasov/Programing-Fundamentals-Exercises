namespace _5.Calculate_Triangle_Area
{
    using System;

    /// Calculate Triangle Area
    public class Program
    {
        public static void Main()
        {
            double triangleBaseWidth = double.Parse(Console.ReadLine());
            double trinagleBaseHeight = double.Parse(Console.ReadLine());
            double triangleArea = ReturnTriangleArea(triangleBaseWidth, trinagleBaseHeight);
            Console.WriteLine(triangleArea);
        }

        public static double ReturnTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
