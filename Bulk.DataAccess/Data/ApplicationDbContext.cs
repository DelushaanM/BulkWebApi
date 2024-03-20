using Bulk.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulk.DataAccess.Data
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
                 new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                 new Category { Id = 2, Name = "Adventure", DisplayOrder = 2 },
                 new Category { Id = 3, Name = "Horror", DisplayOrder = 3 },
                 new Category { Id = 4, Name = "Sci-Fi", DisplayOrder = 4 },
                 new Category { Id = 5, Name = "Fantasy", DisplayOrder = 5 },
                 new Category { Id = 6, Name = "Drama", DisplayOrder = 6 },
                 new Category { Id = 7, Name = "Comedy", DisplayOrder = 7 },
                 new Category { Id = 8, Name = "Thriller", DisplayOrder = 8 },
                 new Category { Id = 9, Name = "Mystery", DisplayOrder = 9 },
                 new Category { Id = 10, Name = "Documentary", DisplayOrder = 10 }
             );

        }
    }
}
