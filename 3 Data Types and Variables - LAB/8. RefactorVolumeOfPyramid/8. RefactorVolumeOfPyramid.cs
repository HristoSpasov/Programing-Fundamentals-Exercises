using System;
//Fixed code for calculating pyramid volume
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Length: ");
        double pyramidBaseLenght  = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        double pyramidBaseWidth = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double pyramidBaseHeight = double.Parse(Console.ReadLine());
        double pyramidVolume = (pyramidBaseLenght * pyramidBaseWidth * pyramidBaseHeight) / 3;
        Console.WriteLine("Pyramid Volume: {0:F2}", pyramidVolume);

    }
}
