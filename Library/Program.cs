using Library.Entities;
using Library.Utilities;
using System.Reflection;

namespace Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bookshelf bookshelf = new Bookshelf();
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

            bookshelf.ShowAllBooks(books);


        }
    }
}
