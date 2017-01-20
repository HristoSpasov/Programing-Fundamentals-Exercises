using System;
//Convert speed units 
class Program
{
    static void Main(string[] args)
    {
        //Read input data
        int distanceMeters = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());

        //Calculate data
        float metersPerSecond = distanceMeters * 1.00f / (seconds + minutes * 60.00f + hours * 3600.00f);
        float kilometersPerHour = (distanceMeters / 1000.00f) / (hours + minutes / 60.00f + seconds / 3600.00f);
        float mph = (distanceMeters / 1609.00f) / (hours + minutes / 60.00f + seconds / 3600.00f);

        //Print and format result on consosle
        Console.WriteLine("{0:0.#######}", metersPerSecond);
        Console.WriteLine("{0:0.#######}", kilometersPerHour);
        Console.WriteLine("{0:0.#######}", mph);

    }
}