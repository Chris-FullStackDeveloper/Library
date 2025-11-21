using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library.Utilities
{
    public class Bookshelf
    {
        public void ShowAllBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"\nBook Added:\nTitle: {book.Title}\nAuthor: {book.Author}\nGenre: {book.Genre}\nLore: {book.Lore}\nRating: {book.Rating}/5");
            }
        }

        public void SortBooksBy(List<Book> books)
        {
            Console.WriteLine("Choose a sort option:");
            Console.WriteLine("1) Sort by title ");
            Console.WriteLine("2) Sort by author ");
            Console.WriteLine("3) Sort by lore ");
            Console.WriteLine("4) Sort by rating ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice) {
                case 1:
            var titleSortedBooks = books
                              .OrderBy(b => b.Title)
                              .ToList();

                    Console.WriteLine("Write a title to search... ");
                    string customTitleToSearch = Console.ReadLine();

                    var customTitleSearch = books.OrderBy(b => b.Title = customTitleToSearch).ToList();
                    if (customTitleSearch == null) { Console.WriteLine("Sorry, this title is currently unavailable"); }

                    break;
                case 2:
            var authorSortedBooks = books
                              .OrderBy(b => b.Author)
                              .ToList();
                    break;
            var loreSortedBooks = books
                              .OrderBy(b => b.Lore)
                              .ToList();
                case 3:
            var ratingSortedBooks = books
                              .OrderBy(b => b.Rating)
                              .ToList();
                    break;
                default:
                    Console.WriteLine("Choose a number between 1 and 4 please");
                    break;
        }
        }
    }
}
