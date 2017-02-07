namespace _1.Day_of_Week
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    
    /// You are given a date in format day-month-year.
    /// Calculate and print the day of week in English.
    public class Program
    {
        public static void Main()
        {
            int[] date = Console.ReadLine()
                .Split('-')
                .Select(int.Parse)
                .ToArray();

            // DateTime(year, month, day) - format
            DateTime result = new DateTime(date[2], date[1], date[0]);

            // Calculate using  parse exact
            //// DateTime result1 = DateTime.ParseExact(string.Join("-", date), "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(result.DayOfWeek);

            // Console.WriteLine(result1.DayOfWeek);
        }
    }
}
