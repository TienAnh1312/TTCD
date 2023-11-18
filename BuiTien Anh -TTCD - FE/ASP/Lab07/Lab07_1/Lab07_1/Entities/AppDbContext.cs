using Lab07_1.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab07_1.Entities
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Banner> banners { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
