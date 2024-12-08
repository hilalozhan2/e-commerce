using Microsoft.EntityFrameworkCore;
using guitars.Models;

namespace guitars.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseMySql("Server=localhost;Database=mydb1;User=Hilal;Password=132132132;", new MySqlServerVersion(new Version(8, 0, 11)));
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
