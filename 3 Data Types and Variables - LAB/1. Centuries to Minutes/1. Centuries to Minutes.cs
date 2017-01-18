using System;

//The following code calculates how many
//minutes are there  in specified century   
class Program
{
    static void Main(string[] args)
    {
        int centuries = int.Parse(Console.ReadLine()); //Reads century integer value
        int years = centuries * 100; //Calculate years
        int days = (int)(years * 365.2422); //Calculate days
        int hours = 24 * days; //Calculate hours
        int minutes = hours * 60; //Calculate minutes

        //Print result
        Console.WriteLine($"{centuries} centuries =" +
                        $"{years} years = {days} days =" +
                        $"{hours} hours = {minutes} minutes");
    }
}

