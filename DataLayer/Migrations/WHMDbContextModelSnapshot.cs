﻿// <auto-generated />
using System;
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(WHMDbContext))]
    partial class WHMDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataLayer.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Categoryname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.HasIndex("CategoryCode", "Categoryname", "IsDeleted")
                        .IsUnique();

                    b.ToTable("Categories", "whm");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryCode = "CAT001",
                            Categoryname = "Electronics",
                            CreatedAt = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Sedded_Data",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryCode = "CAT002",
                            Categoryname = "Electricals",
                            CreatedAt = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Sedded_Data",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryCode = "CAT003",
                            Categoryname = "Furnitures",
                            CreatedAt = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Sedded_Data",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryCode = "CAT004",
                            Categoryname = "Machines",
                            CreatedAt = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Sedded_Data",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryCode = "CAT005",
                            Categoryname = "FootWear",
                            CreatedAt = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Sedded_Data",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryCode = "CAT006",
                            Categoryname = "Medical Equipments",
                            CreatedAt = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Sedded_Data",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryCode = "CAT007",
                            Categoryname = "Appliances",
                            CreatedAt = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Sedded_Data",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryCode = "CAT008",
                            Categoryname = "Beauty Products",
                            CreatedAt = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Sedded_Data",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryCode = "CAT009",
                            Categoryname = "Fitness",
                            CreatedAt = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Sedded_Data",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 10,
                            CategoryCode = "CAT010",
                            Categoryname = "Toys",
                            CreatedAt = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Sedded_Data",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 12,
                            CategoryCode = "asd",
                            Categoryname = "asd",
                            CreatedAt = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Sedded_Dasdata",
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 11,
                            CategoryCode = "CAT0011",
                            Categoryname = "NewDATA",
                            CreatedAt = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Sedded_Data",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("DataLayer.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ManufactureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PricePerProduct")
                        .HasColumnType("int");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubCategoryID")
                        .HasColumnType("int");

                    b.Property<int>("WareHouseID")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("SubCategoryID");

                    b.HasIndex("WareHouseID");

                    b.HasIndex("ProductCode", "SubCategoryID", "PricePerProduct")
                        .IsUnique();

                    b.ToTable("Products", "whm");
                });

            modelBuilder.Entity("DataLayer.Models.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubCategoryID"), 1L, 1);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubCategoryCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SubCategoryname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SubCategoryID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("SubCategoryCode", "SubCategoryname", "IsDeleted")
                        .IsUnique();

                    b.ToTable("SubCategories", "whm");
                });

            modelBuilder.Entity("DataLayer.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserId");

                    b.HasIndex("Email", "IsDeleted")
                        .IsUnique();

                    b.HasIndex("Mobile", "IsDeleted")
                        .IsUnique();

                    b.HasIndex("UserName", "IsDeleted")
                        .IsUnique();

                    b.ToTable("Users", "whm");
                });

            modelBuilder.Entity("DataLayer.Models.WareHouse", b =>
                {
                    b.Property<int>("WareHouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WareHouseId"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WareHouseCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WareHouseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("WareHouseId");

                    b.HasIndex("WareHouseCode", "WareHouseName", "IsDeleted")
                        .IsUnique();

                    b.ToTable("WareHouses", "whm");

                    b.HasData(
                        new
                        {
                            WareHouseId = 1,
                            City = "Chennai",
                            Country = "India",
                            CreatedAt = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Sedded_Data",
                            IsDeleted = false,
                            Latitude = 13.08268,
                            Longitude = 80.270720999999995,
                            State = "TamilNadu",
                            WareHouseCode = "WH001",
                            WareHouseName = "WH_Chennai"
                        },
                        new
                        {
                            WareHouseId = 2,
                            City = "Chennai",
                            Country = "India",
                            CreatedAt = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Sedded_Data",
                            IsDeleted = false,
                            Latitude = 9.9252009999999995,
                            Longitude = 78.119774000000007,
                            State = "TamilNadu",
                            WareHouseCode = "WH002",
                            WareHouseName = "WH_Madurai"
                        },
                        new
                        {
                            WareHouseId = 3,
                            City = "Chennai",
                            Country = "India",
                            CreatedAt = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Sedded_Data",
                            IsDeleted = false,
                            Latitude = 10.790483,
                            Longitude = 78.704673999999997,
                            State = "TamilNadu",
                            WareHouseCode = "WH003",
                            WareHouseName = "WH_Tirchy"
                        },
                        new
                        {
                            WareHouseId = 4,
                            City = "Banglore",
                            Country = "India",
                            CreatedAt = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Sedded_Data",
                            IsDeleted = false,
                            Latitude = 12.971598999999999,
                            Longitude = 77.594566,
                            State = "Karantaka",
                            WareHouseCode = "WH004",
                            WareHouseName = "WH_Bangalore"
                        },
                        new
                        {
                            WareHouseId = 5,
                            City = "Hyderabad",
                            Country = "India",
                            CreatedAt = new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            CreatedBy = "Sedded_Data",
                            IsDeleted = false,
                            Latitude = 17.385044000000001,
                            Longitude = 78.486671000000001,
                            State = "Telangana",
                            WareHouseCode = "WH005",
                            WareHouseName = "WH_Hyderabad"
                        });
                });

            modelBuilder.Entity("DataLayer.Models.Product", b =>
                {
                    b.HasOne("DataLayer.Models.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Models.WareHouse", "Warehouse")
                        .WithMany()
                        .HasForeignKey("WareHouseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("DataLayer.Models.SubCategory", b =>
                {
                    b.HasOne("DataLayer.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
