using Library.Entities;
using Library.Utilities;
using System.Reflection;

namespace Library.Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Initializations elements
            Bookshelf bookshelf = new Bookshelf();
            List<Book> books = new List<Book>();
            int choice;
            #endregion

            do
            {
                // Menù d'interazione
                Console.WriteLine("0) Exit");
                Console.WriteLine("1) Add a book");
                Console.WriteLine("2) Show all books available");
                Console.WriteLine("3) Sort books");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        bookshelf.AddBook(books);
                        break;
                    case 2:
                        bookshelf.ShowAllBooks(books);
                        break;
                    case 3:
                        bookshelf.SortBooksBy(books);
                        break;
                }
            } while (choice != 0);
        }
    }
}

