using System;
using System.Globalization;

/// Calculate non working days between two dates
public class HolidaysBetweenTwoDates
{
    public static void Main()
    {
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        HolidaysCount(startDate, endDate);
        int holidaysCount = HolidaysCount(startDate, endDate);
        Console.WriteLine(holidaysCount);
    }

    public static int HolidaysCount(DateTime startDate, DateTime endDate)
    {
        int holidaysCount = 0;
        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }
        }
        return holidaysCount;
    }
}