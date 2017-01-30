namespace _9.Longer_Line
{
    using System;

    /// Print longer line startong with point closer to center (0,0)
    public class Program
    {
        public static void Main(string[] args)
        {
            /// Read point coordinates from console
            double firstPointX = double.Parse(Console.ReadLine());
            double firstPointY = double.Parse(Console.ReadLine());
            double secondPointX = double.Parse(Console.ReadLine());
            double secondPointY = double.Parse(Console.ReadLine());
            double thirdPointX = double.Parse(Console.ReadLine());
            double thirdPointY = double.Parse(Console.ReadLine());
            double fourthPointX = double.Parse(Console.ReadLine());
            double fourthPointY = double.Parse(Console.ReadLine());

            /// Methods calculating both line lenght
            ReturnFirstLineLenght(firstPointX, firstPointY, secondPointX, secondPointY);
            double firstLineLenght = ReturnFirstLineLenght(firstPointX, firstPointY, secondPointX, secondPointY);
            ReturnSecondLineLenght(thirdPointX, thirdPointY, fourthPointX, fourthPointY);
            double secondLineLenght = ReturnSecondLineLenght(thirdPointX, thirdPointY, fourthPointX, fourthPointY);

            /// Determine which line is longer
            if (firstLineLenght >= secondLineLenght)
            {
                /// Check which point of first line is closer to (0,0)
                ReturnDistanceFromFirstPointToZero(firstPointX, firstPointY);
                double distanceFromFirstPointToZero = ReturnDistanceFromFirstPointToZero(firstPointX, firstPointY);
                ReturnDistanceFromSecondPointToZero(secondPointX, secondPointY);
                double distanceFromSecondPointToZero = ReturnDistanceFromSecondPointToZero(secondPointX, secondPointY);

                /// Print result according to which point is closer to zero
                if (distanceFromFirstPointToZero <= distanceFromSecondPointToZero)
                {
                    Console.WriteLine($"({firstPointX}, {firstPointY})({secondPointX}, {secondPointY})");
                }
                else
                {
                    Console.WriteLine($"({secondPointX}, {secondPointY})({firstPointX}, {firstPointY})");
                }
            }
            else
            {
                /// Check which point of second line is closer to (0,0)
                ReturnDistanceFromThirdPointToZero(thirdPointX, thirdPointY);
                double distanceFromThirdPointToZero = ReturnDistanceFromFirstPointToZero(thirdPointX, thirdPointY);
                ReturnDistanceFromFourthPointToZero(fourthPointX, fourthPointY);
                double distanceFromFourthPointToZero = ReturnDistanceFromSecondPointToZero(fourthPointX, fourthPointY);

                /// Print result according to which point is closer to zero
                if (distanceFromThirdPointToZero <= distanceFromFourthPointToZero)
                {
                    Console.WriteLine($"({thirdPointX}, {thirdPointY})({fourthPointX}, {fourthPointY})");
                }
                else
                {
                    Console.WriteLine($"({fourthPointX}, {fourthPointY})({thirdPointX}, {thirdPointY})");
                }
            }
        }

        /// Calculate lenght of the first line
        public static double ReturnFirstLineLenght(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double xAxisLenght = Math.Abs(firstPointX) + Math.Abs(secondPointX);
            double yAxisLenght = Math.Abs(firstPointY) + Math.Abs(secondPointY);
            double firstLineLenght = Math.Sqrt((yAxisLenght * yAxisLenght) + (xAxisLenght * xAxisLenght));

            return firstLineLenght;
        }

        /// Calculate lenght of the second line
        public static double ReturnSecondLineLenght(double thirdPointX, double thirdPointY, double fourthPointX, double fourthPointY)
        {
            double xAxisLenght = Math.Abs(thirdPointX) + Math.Abs(fourthPointX);
            double yAxisLenght = Math.Abs(thirdPointY) + Math.Abs(fourthPointY);
            double secondLineLenght = Math.Sqrt((yAxisLenght * yAxisLenght) + (xAxisLenght * xAxisLenght));

            return secondLineLenght;
        }

        /// Calculate distance between first point and (0,0)
        public static double ReturnDistanceFromFirstPointToZero(double firstPointX, double firstPointY)
        {
            double distanceToZeroFirstPoint = Math.Sqrt((firstPointX * firstPointX) + (firstPointY * firstPointY));
            return distanceToZeroFirstPoint;
        }

        /// Calculate distance between second point and (0,0)
        public static double ReturnDistanceFromSecondPointToZero(double secondPointX, double secondPointY)
        {
            double distanceToZeroSecondPoint = Math.Sqrt((secondPointX * secondPointX) + (secondPointY * secondPointY));
            return distanceToZeroSecondPoint;
        }

        /// Calculate distance between third point and (0,0)
        public static double ReturnDistanceFromThirdPointToZero(double thirdPointX, double thirdPointY)
        {
            double distanceToZeroThirdPoint = Math.Sqrt((thirdPointX * thirdPointX) + (thirdPointY * thirdPointY));
            return distanceToZeroThirdPoint;
        }

        /// Calculate distance between fourth point and (0,0)
        public static double ReturnDistanceFromFourthPointToZero(double fourthPointX, double fourthPointY)
        {
            double distanceToZeroFourthPoint = Math.Sqrt((fourthPointX * fourthPointX) + (fourthPointY * fourthPointY));
            return distanceToZeroFourthPoint;
        }
    }
}
