using System;
using System.Numerics;
//The code calculates the how many nanoseconds are
//there in chosen centuries
class Program
{
    static void Main(string[] args)
    {
        //Read input inteer for centuries
        int centuries = int.Parse(Console.ReadLine());
        
        //Calculate nanoseconds
        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        int hours = days * 24;
        BigInteger minutes = hours * 60;
        BigInteger seconds = minutes * 60;
        BigInteger miliseconds = seconds * 1000;
        BigInteger microseconds = miliseconds * 1000;
        BigInteger nanoseconds = microseconds * 1000;
        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}