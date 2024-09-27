using Microsoft.EntityFrameworkCore;
using OnlineBookStore.Models;

namespace OnlineBookStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Dot Net", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Physics", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Math", DisplayOrder = 3 }
                );
        }
    }
}
