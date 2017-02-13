namespace _10.Student_Groups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();

            var towns = new List<Town>();

            while (line != "End")
            {
                var townInfo = Regex.Match(line, @"(?<town>.+) => (?<seats>\d+) seats");

                if (townInfo.Success)
                {
                    var townName = townInfo.Groups["town"].Value;
                    var seats = int.Parse(townInfo.Groups["seats"].Value);

                    var town = new Town()
                    {
                        Name = townName,
                        SeatCount = seats
                    };

                    towns.Add(town);
                }
                else
                {
                    var tokens = line.Split('|').Select(a => a.Trim()).ToArray();

                    var name = tokens[0];
                    var email = tokens[1];
                    var registrationDate = DateTime.ParseExact(tokens[2], "d-MMM-yyyy", null);

                    var student = new Student()
                    {
                        Name = name,
                        Email = email,
                        RegistrationDate = registrationDate
                    };

                    Console.WriteLine();
                }

                line = Console.ReadLine();
            }
        }

        public static List<Town> ReadTownsAndStudents()
        {
            var towns = new List<Town>();


            return towns;
        }
    }
}
