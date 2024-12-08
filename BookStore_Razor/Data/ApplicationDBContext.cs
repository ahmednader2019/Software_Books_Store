using BookStore_Razor.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore_Razor.Data
{
    public class ApplicationDBContext
    {
        public class ApplicationDBContxt : DbContext
        {
            public ApplicationDBContxt(DbContextOptions<ApplicationDBContxt> options) : base(options)
            {

            }

            public DbSet<Category>Categories { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Name = "Science", DisplayOrder = 1 },
                    new Category { Id = 2, Name = "Action", DisplayOrder = 2 },
                    new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                    );
            }
        }
    }
}
