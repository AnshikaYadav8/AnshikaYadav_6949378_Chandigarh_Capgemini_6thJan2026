using Microsoft.EntityFrameworkCore;
using MVCProject.Models;

namespace MVCProject.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        public DbSet<BookModel> Books { get; set; }

        public DbSet<PublisherModel> Publishers { get; set; } // NEW MODEL
    }
}