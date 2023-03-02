using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.ContextSeedData
{
    public static class CategorySeedData
    {
        public static void CategorySeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    Categoryname = "Electronics",
                    CategoryCode = "CAT001",
                    CreatedBy = "Sedded_Data",
                    CreatedAt = DateTime.Today.Date,
                    IsDeleted = false
                },
                new Category()
                {
                    CategoryId = 2,
                    Categoryname = "Electricals",
                    CategoryCode = "CAT002",
                    CreatedBy = "Sedded_Data",
                    CreatedAt = DateTime.Today.Date,
                    IsDeleted = false

                },
                new Category()
                {
                    CategoryId = 3,
                    Categoryname = "Furnitures",
                    CategoryCode = "CAT003",
                    CreatedBy = "Sedded_Data",
                    CreatedAt = DateTime.Today.Date,
                    IsDeleted = false
                },
                new Category()
                {
                    CategoryId = 4,
                    Categoryname = "Machines",
                    CategoryCode = "CAT004",
                    CreatedBy = "Sedded_Data",
                    CreatedAt = DateTime.Today.Date,
                    IsDeleted = false
                },
                new Category()
                {
                    CategoryId = 5,
                    Categoryname = "FootWear",
                    CategoryCode = "CAT005",
                    CreatedBy = "Sedded_Data",
                    CreatedAt = DateTime.Today.Date,
                    IsDeleted = false
                },
                new Category()
                {
                    CategoryId = 6,
                    Categoryname = "Medical Equipments",
                    CategoryCode = "CAT006",
                    CreatedBy = "Sedded_Data",
                    CreatedAt = DateTime.Today.Date,
                    IsDeleted = false
                },
                new Category()
                {
                    CategoryId = 7,
                    Categoryname = "Appliances",
                    CategoryCode = "CAT007",
                    CreatedBy = "Sedded_Data",
                    CreatedAt = DateTime.Today.Date,
                    IsDeleted = false
                },
                new Category()
                {
                    CategoryId = 8,
                    Categoryname = "Beauty Products",
                    CategoryCode = "CAT008",
                    CreatedBy = "Sedded_Data",
                    CreatedAt = DateTime.Today.Date,
                    IsDeleted = false

                },
                new Category()
                {
                    CategoryId = 9,
                    Categoryname = "Fitness",
                    CategoryCode = "CAT009",
                    CreatedBy = "Sedded_Data",
                    CreatedAt = DateTime.Today.Date,
                    IsDeleted = false

                },
                new Category()
                {
                    CategoryId = 10,
                    Categoryname = "Toys",
                    CategoryCode = "CAT010",
                    CreatedBy = "Sedded_Data",
                    CreatedAt = DateTime.Today.Date,
                    IsDeleted = false
                },
                 new Category()
                 {
                     CategoryId = 12,
                     Categoryname = "asd",
                     CategoryCode = "asd",
                     CreatedBy = "Sedded_Dasdata",
                     CreatedAt = DateTime.Today.Date,
                     IsDeleted = false
                 }
            );
        }

        public static void NewCategorySeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 11,
                    Categoryname = "NewDATA",
                    CategoryCode = "CAT0011",
                    CreatedBy = "Sedded_Data",
                    CreatedAt = DateTime.Today.Date,
                    IsDeleted = false
                });
        }
    }
}
