namespace _3.Printing_Triangle
{
    using System;

    /// Print triangle of numbers
    public class Program
    {
        public static void Main()
        {
            int triangleSize = int.Parse(Console.ReadLine());
            TriangleTopPrint(triangleSize);
            TriangleBottomPrint(triangleSize - 1);
        }

        public static void TriangleTopPrint(int triangleSize)
        {
            for (int row = 1; row <= triangleSize; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }

                Console.WriteLine();
            }
        }

        public static void TriangleBottomPrint(int triangleSize)
        {
            for (int row = triangleSize; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
