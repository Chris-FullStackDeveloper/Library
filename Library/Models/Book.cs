namespace Library.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Lore { get; set; }
        //public Genres Genre { get; set; } 
        //public List<Genres> Genre {  get; set; }
        // Utilizzo ICollection al posto di List perchè EF Core può sostituire la collezione con una propria implementazione per il tracking delle entità (più flessibile)
        public ICollection<Genre> Genre { get; set; }
        public int Rating { get; set; }
    }
}
