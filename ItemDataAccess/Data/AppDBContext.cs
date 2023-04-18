using Item.Models;
using Microsoft.EntityFrameworkCore;

namespace Item.DataAccess.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        {
            
        }

        public DbSet<Items> Items { get; set; }
		public DbSet<Product> Products { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Items>().HasData(
                    new Items { Id = 1, Name = "Bread", Price = 2},
                    new Items { Id = 2, Name = "Butter", Price = 9},
                    new Items { Id = 3, Name = "Jam", Price = 5}
                );

            modelBuilder.Entity<Product>().HasData(
					 new Product
					 {
						 Id = 1,
						 Title = "The Great Gatsby",
						 Description = "A novel by F. Scott Fitzgerald",
						 ISBN = "978-0743273565",
						 Author = "F. Scott Fitzgerald",
						 ListPrice = 15.99,
						 Price = 10.99,
						 Price50 = 8.99,
						 Price100 = 7.99
					 },
					new Product
					{ 
						Id = 2,
						Title = "To Kill a Mockingbird",
						Description = "A novel by Harper Lee",
						ISBN = "978-0446310789",
						Author = "Harper Lee",
						ListPrice = 12.99,
						Price = 8.99,
						Price50 = 6.99,
						Price100 = 5.99
					},
					new Product
					{
						Id = 3,
						Title = "1984",
						Description = "A dystopian novel by George Orwell",
						ISBN = "978-0451524935",
						Author = "George Orwell",
						ListPrice = 14.99,
						Price = 9.99,
						Price50 = 7.99,
						Price100 = 6.99
					},
					new Product
					{
						Id = 4,
						Title = "Pride and Prejudice",
						Description = "A novel by Jane Austen",
						ISBN = "978-0486284736",
						Author = "Jane Austen",
						ListPrice = 11.99,
						Price = 7.99,
						Price50 = 5.99,
						Price100 = 4.99
					},
					new Product
					{
						Id = 5,
						Title = "The Catcher in the Rye",
						Description = "A novel by J.D. Salinger",
						ISBN = "978-0316769488",
						Author = "J.D. Salinger",
						ListPrice = 13.99,
						Price = 9.99,
						Price50 = 7.99,
						Price100 = 6.99
					},
					new Product
					{
						Id = 6,
						Title = "The Hobbit",
						Description = "A novel by J.R.R. Tolkien",
						ISBN = "978-0547928227",
						Author = "J.R.R. Tolkien",
						ListPrice = 18.99,
						Price = 12.99,
						Price50 = 10.99
					}

				);


		}

	}
}
