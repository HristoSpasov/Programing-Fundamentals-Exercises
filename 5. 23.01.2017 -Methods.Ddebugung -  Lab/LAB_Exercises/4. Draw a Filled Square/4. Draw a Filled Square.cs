namespace _4.Draw_a_Filled_Square
{
    using System;

    /// Draw filled square
    public class Program
    {
        public static void Main()
        {
            int squareSize = int.Parse(Console.ReadLine());
            SquareTopLine(2 * squareSize);
            SquareMiddle(squareSize - 2, 2 * squareSize);
            SquareTopLine(2 * squareSize);
        }

        public static void SquareTopLine(int topline)
        {
            Console.WriteLine(new string('-', topline));
        }

        public static void SquareMiddle(int rowCount, int colCount)
        {
            for (int row = 1; row <= rowCount; row++)
            {
                Console.Write("-");
                for (int col = 1; col <= colCount - 2; col++)
                {
                    if (col % 2 != 0)
                    {
                        Console.Write(@"\");
                    }
                    else
                    {
                        Console.Write(@"/");
                    }
                }

                Console.WriteLine("-");
            }
        }
    }
}
