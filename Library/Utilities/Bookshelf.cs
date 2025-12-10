using Library.Entities;
using System.Linq;

namespace Library.Utilities
{
    public class Bookshelf
    {
        List<Genre> genres = new List<Genre>();

        public void AddBook(List<Book> books)
        {
            Console.WriteLine("Welcome to the Library! Please add a book:");

            // TITOLO
            Console.Write("Title: ");
            string title = Console.ReadLine();

            // AUTORE
            Console.Write("Author: ");
            string author = Console.ReadLine();

            // GENERI
            Console.Write("Genre (Action, Adventure, Comedy, Drama, Fantasy, Horror, Mystery, Romance, SciFi), or multiple genres separated by ',': ");
            string genreInput = Console.ReadLine();

            //foreach (var g in genreInput.Split(',', StringSplitOptions.RemoveEmptyEntries))
            //{
            //    // Controllo che l'utente inserisca un genere valido, ovvero, che coincida con i valori che la classe enum "Genres"
            //    // restituendo un valore di tipo Enum da poter inserire successivamente nell'oggetto Book
            //    // Utilizzo il TryParse per non far crashare il programma con il Parse
            //    if (Enum.TryParse<Genres>(g.Trim(), true, out Genres parsed))
            //    {
            //        genres.Add(parsed);
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Genere sconosciuto: {g}");
            //    }
            //}

            foreach (var g in genreInput.Split(','))
            {
                string cleaned = g.Trim();

                // Ignora TUTTE le stringhe vuote o fatte solo di spazi
                if (string.IsNullOrWhiteSpace(cleaned))
                    continue;

                if (Enum.TryParse<Genre>(cleaned, true, out Genre parsed))
                {
                    genres.Add(parsed);
                }
                else
                {
                    Console.WriteLine($"Genere sconosciuto: {cleaned}");
                }
            }

            // TRAMA
            Console.Write("Lore: ");
            string lore = Console.ReadLine();

            // VALUTAZIONE
            Console.Write("Rating (1-5): ");
            int rating = int.Parse(Console.ReadLine());

            // AGGIUNTA DEI DATI
            books.Add(new Book { Title = title, Author = author, Genre = genres, Lore = lore, Rating = rating });
        }
        public void ShowAllBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"\nBook Added:\nTitle: {book.Title}\nAuthor: {book.Author}\nLore: {book.Lore}\nRating: {book.Rating}/5");
                Console.Write("Genres: ");
                Console.WriteLine(string.Join(", ", book.Genre));
            }
            //foreach (var genre in genres)
            //{
            //    Console.Write($"{genre.ToString()} ");
            //}
        }
        public void SortBooksBy(List<Book> books)
        {
            int choice = default;
            do
            {
                Console.WriteLine("Choose a sort option:");
                Console.WriteLine("0) Exit ");
                Console.WriteLine("1) Sort by title ");
                Console.WriteLine("2) Sort by author ");
                Console.WriteLine("3) Sort by rating ");
                Console.WriteLine("4) Sort by genre ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        var titleSortedBooks = books
                                          .OrderBy(b => b.Title)
                                          .ToList();

                        Console.WriteLine("Write a title to search... ");
                        string customTitleToSearch = Console.ReadLine();

                        var customTitleSearch = books.Where(b => b.Title.Equals(customTitleToSearch, StringComparison.OrdinalIgnoreCase)).ToList();

                        if (customTitleSearch.Count == 0) { Console.WriteLine("Sorry, this title is currently unavailable"); }
                        else
                        {
                            foreach (var book in customTitleSearch)
                            {
                                Console.WriteLine($"\nBook sorted:\nTitle: {book.Title}\nAuthor: {book.Author}\nGenre: {book.Genre}\nLore: {book.Lore}\nRating: {book.Rating}/5");
                            }
                        }

                        break;

                    case 2:
                        var authorSortedBooks = books
                                          .OrderBy(b => b.Author)
                                          .ToList();

                        Console.WriteLine("Write an author name to search... ");
                        string customAuthorToSearch = Console.ReadLine();

                        var customAuthorSearch = books.Where(b => b.Author.Equals(customAuthorToSearch, StringComparison.OrdinalIgnoreCase)).ToList();

                        if (customAuthorSearch.Count == 0) { Console.WriteLine("Sorry, there isn't any book with that author here"); }
                        else
                        {
                            foreach (var book in customAuthorSearch)
                            {
                                Console.WriteLine($"\nBook sorted:\nTitle: {book.Title}\nAuthor: {book.Author}\nGenre: {book.Genre}\nLore: {book.Lore}\nRating: {book.Rating}/5");
                            }
                        }

                        break;

                    case 3:
                        var ratingSortedBooks = books
                                          .OrderBy(b => b.Rating)
                                          .ToList();

                        Console.WriteLine("Write a rating to search... ");
                        int customRatingToSearch = int.Parse(Console.ReadLine());

                        var customRatingSearch = books.Where(b => b.Rating == customRatingToSearch).ToList();

                        if (customRatingSearch.Count == 0) { Console.WriteLine("Sorry, there isn't any book with that rating here"); }

                        foreach (var book in customRatingSearch)
                        {
                            Console.WriteLine($"\nBook sorted:\nTitle: {book.Title}\nAuthor: {book.Author}\nGenre: {book.Genre}\nLore: {book.Lore}\nRating: {book.Rating}/5");
                        }

                        break;

                    case 4:
                        var genreSortedBooks = books
                                          .OrderBy(b => b.Genre)
                                          .ToList();

                        Console.WriteLine("Write a genre to search... ");
                        Console.WriteLine("1) Action ");
                        Console.WriteLine("2) Adventure ");
                        Console.WriteLine("3) Comedy ");
                        Console.WriteLine("4) Drama ");
                        Console.WriteLine("5) Fantasy ");
                        Console.WriteLine("6) Horror ");
                        Console.WriteLine("7) Mystery ");
                        Console.WriteLine("8) Romance ");
                        Console.WriteLine("9) SciFi ");
                        int customGenreToSearch = int.Parse(Console.ReadLine());
                        //string myEnumValue = Enum.GetName(typeof (Genres), customGenreToSearch);

                        var customGenreSearch = books.Where(b => b.Genre.Contains((Genre)customGenreToSearch)).ToList();
                        if (customGenreSearch.Count == 0) { Console.WriteLine("Sorry, there is no book available in the selected genre"); }
                        else
                        {
                            foreach (var book in customGenreSearch)
                            {
                                Console.WriteLine($"\nBook sorted:\nTitle: {book.Title}\nAuthor: {book.Author}\nGenre: {book.Genre}\nLore: {book.Lore}\nRating: {book.Rating}/5");
                            }
                        }

                        break;

                    default:
                        if (choice < 0 || choice > 4)
                        {
                            Console.WriteLine("Choose a number between 0 and 4 please");
                        }
                        else if(choice == 0)
                        {
                            Console.WriteLine("Leaving sorting menu...");
                        }
                        break;
                }
            } while (choice != 0);
        }
    }
}
