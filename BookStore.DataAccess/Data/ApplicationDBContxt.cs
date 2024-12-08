using BookStore.Models;
using BookStore.Models.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class ApplicationDBContxt : IdentityDbContext<IdentityUser>
    {
        public ApplicationDBContxt(DbContextOptions<ApplicationDBContxt>options):base(options)
        {
                
        }

       public DbSet<Category>Categories { get; set; }
       public DbSet<Product> Products { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Company> Companies { get; set; }   

        public DbSet<ApplicationUser>ApplicationUsers { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public DbSet<OrderHeader> OrderHeaders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Science", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Action", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Company>().HasData(
               new Company { Id = 1, Name = "Tech Solution", city = "Cairo" , phoneNumber ="1223456" , postalCode="1243" , state="Mahalla" , streetAddress="124 st - Mahalla" },
               new Company { Id = 2, Name = "CodeZone", city = "Mansoura", phoneNumber = "1223456", postalCode = "1243", state = "Mahalla", streetAddress = "124 st - Mahalla" }
               );

            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                   Id = 1,
                   Title = "Bulky Store",
                   Author = "Ahmed nader",
                   Description = " Fgfg fgfgfg ",
                   ISBN = "12345",
                   ListPrice = 12374,
                   Price = 54545,
                   Price50 = 124,
                   Price100 = 12334,
                   CategoryId = 1,
                   ImageURL = ""
               },
               new Product
               {
                   Id = 2,
                   Title = "Book Store",
                   Author = "Tarek nader",
                   Description = " ghgfhg  ",
                   ISBN = "43433",
                   ListPrice = 126574,
                   Price = 53545,
                   Price50 = 187,
                   Price100 = 134534,
                   CategoryId = 2,
                   ImageURL = ""
               },
               new Product
               {
                   Id = 3,
                   Title = "JR Store",
                   Author = "trtr",
                   Description = " adssf assas  ",

                   ISBN = "12875",
                   ListPrice = 54543,
                   Price = 145,
                   Price50 = 8756,
                   Price100 = 1984,
                   CategoryId = 1,
                   ImageURL = ""
               },
               new Product
               {
                   Id = 4,
                   Title = "Clothing Store",
                   Author = "New Manager",
                   Description = " sfdfdsf  ",

                   ISBN = "76454",
                   ListPrice = 9243,
                   Price = 32124,
                   Price50 = 7679,
                   Price100 = 1423,
                   CategoryId = 3,
                   ImageURL = ""
               }
               );
        }
    }
}
