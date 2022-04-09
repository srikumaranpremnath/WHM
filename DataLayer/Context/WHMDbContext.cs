using DataLayer.ContextSeedData;
using DataLayer.Models;
using DataLayer.TableIndex;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Context
{
    public class WHMDbContext : DbContext
    {
        public WHMDbContext(DbContextOptions options) : base(options)
        {
            //Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.CategorySeed();
            modelBuilder.WareHouseSeed();
            modelBuilder.WHMTableIndex();

        }
        public DbSet<User> User { get; set; }
        public DbSet<WareHouse> WareHouse { get; set; }
        public DbSet<Category> Caterogry { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
