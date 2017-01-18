using System;
//The follwing code calculates How many cources are needed
//to elevate "n" persons with elevator with 'p' people capacity
class Program
{
    static void Main(string[] args)
    {
        int peopleToElevate = int.Parse(Console.ReadLine()); // All people
        int peoplePerCourse = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}", (int)Math.Ceiling((double)peopleToElevate / peoplePerCourse));
    }
}

