using System;

//The following code:
//1. Reads the radius of circle in console
//2. Calculates circle area with 12 digits after decimal point
class Program
{
    static void Main(string[] args)
    {
        double circleRadius = double.Parse(Console.ReadLine()); // Reads circle radius from console
        Console.WriteLine("{0:F12}", Math.PI * circleRadius * circleRadius); // Calculates and prints result area
    }
}

