using FA.BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace FA.BookStore.Data
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
