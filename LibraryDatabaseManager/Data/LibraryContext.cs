using Library.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDatabaseManager.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; } = null;
        public DbSet<Genre> Genres { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=myServerName\\myInstanceName;Database=myDataBase;User Id=user;Password=admin;");
        }
    }
}
