namespace _2.AdvMessage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<string> phrases = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            List<string> events = new List<string>
            {
               "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            List<string> author = new List<string>
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            List<string> cities = new List<string>
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            int numberOfMessages = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            for (int i = 0; i < numberOfMessages; i++)
            {
                string resultString = string.Empty;
                int phrasesTmpIndex = rnd.Next(0, phrases.Count);
                int eventsTmpIndex = rnd.Next(0, events.Count);
                int authorTmpIndex = rnd.Next(0, author.Count);
                int citiesTmpIndex = rnd.Next(0, cities.Count);

                resultString += $"{phrases[phrasesTmpIndex]} {events[eventsTmpIndex]} {author[authorTmpIndex]} - {cities[citiesTmpIndex]}";

                Console.WriteLine(resultString);
            }
        }
    }
}
