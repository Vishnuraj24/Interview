using LazyLoading.Models;
using Microsoft.EntityFrameworkCore;

namespace LazyLoading.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Book> books { get; set; }
        public DbSet<Author> authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var author1 = new Author
            {
                AuthorId = 1,
                Name = "Random Author 1"
            };
            var author2 = new Author
            {
                AuthorId = 2,
                Name = "Random Author 2"
            };

            List<Book> books = new List<Book>
            {
                new Book { BookId = 1, AuthorId = 1, Title = "Some Random Book1", NumberOfPages = 23 },
                new Book { BookId = 2, AuthorId = 2, Title = "Some Random Book2", NumberOfPages = 50 }
            };
            modelBuilder.Entity<Book>().HasData(books);
            modelBuilder.Entity<Author>().HasData(author1,author2);
        }


    }
}
