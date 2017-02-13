namespace _5.Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int numberOfBooks = int.Parse(Console.ReadLine()); // Number of books to read

            List<Library> library = new List<Library>(); // List to store book data

            /// Loop and get data for each book
            for (int i = 0; i < numberOfBooks; i++)
            {
                string[] currBook = Console.ReadLine().Split();

                Library currentBook = new Library
                {
                    Title = currBook[0],
                    Author = currBook[1],
                    Publisher = currBook[2],
                    ReleaseDate = DateTime.ParseExact(currBook[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = currBook[4],
                    Price = decimal.Parse(currBook[5])
                };

                library.Add(currentBook);
            }

            /// Filter library to match criteria
            var result = library.GroupBy(x => x.Author)
              .Select(x => new
              {
                  Author = x.First().Author,
                  Price = x.Sum(y => y.Price)
              }).ToList();

            /// Print result
            foreach (var book in result.OrderByDescending(x => x.Price).ThenBy(x => x.Author))
            {
                Console.WriteLine($"{book.Author} -> {book.Price:F2}");
            }
        }
    }
}
