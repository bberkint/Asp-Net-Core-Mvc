using Library.Configurations;
using Library.Initializer;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DataInitializer.Seed(modelBuilder);

            // Operation tablosu için
            modelBuilder.ApplyConfiguration(new OperationConfiguration());

            // Author tablosu için
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());

            //Student tablosu için 
            modelBuilder.ApplyConfiguration(new StudentConfiguration());

            //Book için 
            modelBuilder.ApplyConfiguration(new BookConfiguration());

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AppUser> Users { get; set; }
    }
}
