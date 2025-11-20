using Library.Entities;
using Library.Utilities;
using System.Reflection;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            Console.WriteLine("Welcome to the Library! Please add a book:");
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Console.Write("Genre (Action, Adventure, Comedy, Drama, Fantasy, Horror, Mystery, Romance, SciFi): ");
            string genreInput = Console.ReadLine();
            Genres genre = (Genres)Enum.Parse(typeof(Genres), genreInput, true);
            Console.Write("Lore: ");
            string lore = Console.ReadLine();
            Console.Write("Rating (1-5): ");
            int rating = int.Parse(Console.ReadLine());

            books.Add(new Book{ Title = title, Author = author, Genre = genre, Lore = lore, Rating = rating });

            foreach (var book in books)
            {
                Console.WriteLine($"\nBook Added:\nTitle: {book.Title}\nAuthor: {book.Author}\nGenre: {book.Genre}\nLore: {book.Lore}\nRating: {book.Rating}/5");
            }
        }
    }
}
