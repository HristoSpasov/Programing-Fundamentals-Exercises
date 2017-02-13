namespace _6.BookLibraryMod
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int numberOfBooks = int.Parse(Console.ReadLine());

            List<Library> library = new List<Library>();

            for (int i = 0; i < numberOfBooks; i++)
            {
                string[] currentBook = Console.ReadLine().Split();

                Library currBook = new Library
                {
                    Title = currentBook[0],
                    Author = currentBook[1],
                    Publisher = currentBook[2],
                    ReleaseDate = DateTime.ParseExact(currentBook[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = currentBook[4],
                    Price = decimal.Parse(currentBook[5])
                };

                library.Add(currBook);
            }

            DateTime compareDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in library.Where(x => x.ReleaseDate > compareDate).OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}");
            }
        }
    }
}
