namespace _9.Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("./Input.txt");

            List<Library> libraryList = new List<Library>();

            foreach (var book in input)
            {
                string[] currBookInfo = book.Split();

                Library currBook = new Library
                {
                    Title = currBookInfo[0],
                    Author = currBookInfo[1],
                    Publisher = currBookInfo[2],
                    ReleaseDate = DateTime.ParseExact(currBookInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = currBookInfo[4],
                    Price = decimal.Parse(currBookInfo[5])
                };

                libraryList.Add(currBook);
            }

            var groupedLibrary = libraryList.GroupBy(x => x.Author)
                        .Select(x => new
                        {
                            Author = x.First().Author,
                            Price = x.Sum(y => y.Price)
                        })
                        .ToList();

            if (File.Exists("./Output.txt"))
            {
                File.Delete("./Output.txt");
            }

            foreach (var group in groupedLibrary.OrderByDescending(x => x.Price)
                .ThenBy(x => x.Author))
            {
                File.AppendAllText("./Output.txt", $"{group.Author} -> {group.Price:F2}\r\n");
            }
        }
    }
}
