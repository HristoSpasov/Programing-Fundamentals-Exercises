namespace _7.Advertisement_Message
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] phrases = File.ReadAllLines("./Phrases.txt");
            string[] events = File.ReadAllLines("./Events.txt");
            string[] author = File.ReadAllLines("./Author.txt");
            string[] cities = File.ReadAllLines("./Cities.txt");

            Random rnd = new Random();
            int messagesToGenerate = int.Parse(Console.ReadLine());

            if (File.Exists("./Output.txt"))
            {
                File.Delete("./Output.txt");
            }

            for (int i = 0; i < messagesToGenerate; i++)
            {
                string currPhrase = phrases[rnd.Next(phrases.Length)];
                string currEvent = events[rnd.Next(events.Length)];
                string currAuthor = author[rnd.Next(author.Length)];
                string currCity = cities[rnd.Next(cities.Length)];

                File.AppendAllText("./Output.txt", $"{currPhrase} {currEvent} {currAuthor} – {currCity}\r\n");
            }   
        }
    }
}