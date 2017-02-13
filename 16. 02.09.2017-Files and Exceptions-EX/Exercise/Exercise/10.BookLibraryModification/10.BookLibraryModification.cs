namespace _10.BookLibraryModification
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
            Console.Write("Enter start date to filter books: ");
            DateTime filterDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            string[] input = File.ReadAllLines("./Input.txt");

            List<Library> booksLibrary = new List<Library>();

            foreach (var book in input)
            {
                string[] currBookArr = book.Split();

                Library currBook = new Library
                {
                    Title = currBookArr[0],
                    Author = currBookArr[1],
                    Publisher = currBookArr[2],
                    ReleaseDate = DateTime.ParseExact(currBookArr[3], "dd.MM.yyyy", CultureInfo.InstalledUICulture),
                    ISBN = currBookArr[4],
                    Price = decimal.Parse(currBookArr[5])
                };

                booksLibrary.Add(currBook);
            }

            if (File.Exists("./Output.txt"))
            {
                File.Delete("./Output.txt");
            }

            foreach (var book in booksLibrary.Where(x => x.ReleaseDate > filterDate)
                .OrderBy(x => x.ReleaseDate)
                .ThenBy(x => x.Title))
            {
                File.AppendAllText("./Output.txt", $"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}\r\n");
            }
        }
    }
}
