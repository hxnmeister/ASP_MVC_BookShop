using ASP_MVC_BookShop.DB.Models;
using ASP_MVC_BookShop.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_MVC_BookShop.ViewModels
{
    public class BookShopDBContext : DbContext
    {
        public DbSet<AuthorModel> Authors { get; set; }
        public DbSet<BookModel> Books { get; set; }

        public BookShopDBContext(DbContextOptions<BookShopDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookModel>()
            .HasOne(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.AuthorId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
