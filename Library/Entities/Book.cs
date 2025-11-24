using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Lore { get; set; }
        //public Genres Genre { get; set; } 
        public List<Genres> Genre {  get; set; }
        public int Rating { get; set; }
    }
}
