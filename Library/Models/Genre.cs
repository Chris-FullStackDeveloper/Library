namespace Library.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
        public List<string> genres = new List<string>();

        public Genre()
        {
            genres.AddRange(new string[] { "Romanzo", "Storico", "Fantasy", "Avvventura", "Biografia", "Filosofia", "Horror", "Thriller" });
        }
    }
}
