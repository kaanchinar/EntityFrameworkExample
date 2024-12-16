using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkExample.Models
{
    public class AppDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=entity;Username=postgres;Password=SuperAdmin");
        }
    }
}
