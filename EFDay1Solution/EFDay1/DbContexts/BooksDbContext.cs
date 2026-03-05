using EFDay1.ConfigurationClasses;
using EFDay1.Models;
using Microsoft.EntityFrameworkCore;


namespace EFDay1.DbContexts
{
    internal class BooksDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BookStore;Trusted_Connection=True;");
        }
        DbSet<Book> Books { get; set; } 
        DbSet<Author> Authors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Book>()
            //            .ToTable("Books");

            //modelBuilder.Entity<Book>()
            //            .Property(B => B.Id)
            //            .HasColumnName("BookId")
            //            .IsRequired(true);

            //modelBuilder.Entity<Book>()
            //            .Property(B => B.Title)
            //            .HasColumnName("Title")
            //            .HasColumnType("varchar")
            //            .HasMaxLength(150)
            //            .IsRequired(true);

            //modelBuilder.Entity<Book>()
            //            .Property(B => B.Price)
            //            .HasColumnName("BookPrice")
            //            .HasColumnType("decimal(18,2)");

            //modelBuilder.Entity<Book>()
            //            .Property(B => B.PublishedDate)
            //            .HasColumnName("PublishedDate")
            //            .HasColumnType("datetime2(7)")
            //            .IsRequired(false);

            modelBuilder.ApplyConfiguration(new BookConfigurations());



        }
    }
}
