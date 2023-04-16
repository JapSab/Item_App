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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Items>().HasData(
                    new Items { Id = 1, Name = "Bread", Price = 2},
                    new Items { Id = 2, Name = "Butter", Price = 9},
                    new Items { Id = 3, Name = "Jam", Price = 5}
                );
        }

    }
}
