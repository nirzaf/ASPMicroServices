using Microsoft.EntityFrameworkCore;

namespace AccountService.Models
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}