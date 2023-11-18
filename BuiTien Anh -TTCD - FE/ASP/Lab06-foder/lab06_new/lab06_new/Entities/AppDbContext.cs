using lab06_5.Models;
using Microsoft.EntityFrameworkCore;

namespace lab06_5_new.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Marks> marks { get; set; }
        public DbSet<StdClass> stdClasses { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Subject> subjects { get; set; }
    }
}
