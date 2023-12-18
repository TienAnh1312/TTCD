using Lab06_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab06_1.Entities
{
    public class AddDbContext: DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get;}
    }
}
