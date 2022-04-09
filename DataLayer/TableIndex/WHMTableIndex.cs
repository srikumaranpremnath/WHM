using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.TableIndex
{
    public static class IndexCreation
    {
        public static void WHMTableIndex(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasIndex(index => new { index.CategoryCode, index.Categoryname, index.IsDeleted })
                .IsUnique();
            modelBuilder.Entity<SubCategory>()
                .HasIndex(index => new { index.SubCategoryCode, index.SubCategoryname, index.IsDeleted })
                .IsUnique();
            modelBuilder.Entity<User>()
                .HasIndex(index => new { index.Mobile, index.IsDeleted })
                .IsUnique();
            modelBuilder.Entity<User>()
                .HasIndex(index => new { index.Email, index.IsDeleted })
                .IsUnique();
            modelBuilder.Entity<User>()
                .HasIndex(index => new { index.Mobile, index.IsDeleted })
                .IsUnique();
            modelBuilder.Entity<User>()
                .HasIndex(index => new { index.UserName, index.IsDeleted })
                .IsUnique();
            modelBuilder.Entity<WareHouse>()
                .HasIndex(index => new { index.WareHouseCode, index.WareHouseName, index.IsDeleted })
                .IsUnique();
            modelBuilder.Entity<Product>()
                .HasIndex(index => new { index.ProductCode, index.SubCategoryID, index.PricePerProduct })
                .IsUnique();
        }
    }
}
