namespace _10.Cube_Properties
{
    using System;

    /// Calculete cube parameters face/space/volume/area,
    /// according to given cube side and one of the parameters
    public class Program
    {
        public static void Main(string[] args)
        {
            /// Read input parameters from console
            double cubeSide = double.Parse(Console.ReadLine());
            string cubeParameter = Console.ReadLine();

            /// Methods for different cube parameters
            ReturnFaceDiagonal(cubeSide);
            ReturnSpaceDiagonal(cubeSide);
            ReturnVolume(cubeSide);
            ReturnSurfaceArea(cubeSide);

            /// Print result according to input data
            if (cubeParameter == "face")
            {
                Console.WriteLine("{0:F2}", ReturnFaceDiagonal(cubeSide));
            }
            else if (cubeParameter == "space")
            {
                Console.WriteLine("{0:F2}", ReturnSpaceDiagonal(cubeSide));
            }
            else if (cubeParameter == "volume")
            {
                Console.WriteLine("{0:F2}", ReturnVolume(cubeSide));
            }
            else
            {
                Console.WriteLine("{0:F2}", ReturnSurfaceArea(cubeSide));
            }
        }

        /// Calculate the lenght of the face diagonal
        public static double ReturnFaceDiagonal(double cubeSide)
        {
            double faceDiagonalLenght = Math.Sqrt(2 * cubeSide * cubeSide);

            return faceDiagonalLenght;
        }

        /// Calculate the lenght of the space diagonal
        public static double ReturnSpaceDiagonal(double cubeSide)
        {
            double spaceDiagonalLenght = Math.Sqrt(3 * cubeSide * cubeSide);

            return spaceDiagonalLenght;
        }

        /// Calculate the volume
        public static double ReturnVolume(double cubeSide)
        {
            double cubeVolume = Math.Pow(cubeSide, 3.0);

            return cubeVolume;
        }

        /// Calculate the surface area
        public static double ReturnSurfaceArea(double cubeSide)
        {
            double surfaceArea = 6 * cubeSide * cubeSide;

            return surfaceArea;
        }
    }
}
