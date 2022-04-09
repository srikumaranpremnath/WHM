using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.ContextSeedData
{

    public static class WareHouseSeedData
    {
        public static void WareHouseSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WareHouse>().HasData(
                new WareHouse()
                {
                    WareHouseId = 1,
                    WareHouseCode = "WH001",
                    City = "Chennai",
                    Country = "India",
                    Latitude = 13.08268,
                    Longitude = 80.270720999999995,
                    State = "TamilNadu",
                    WareHouseName = "WH_Chennai",
                    CreatedBy = "Sedded_Data",
                    CreatedAt = DateTime.Today.Date,
                    IsDeleted = false
                },
                new WareHouse()
                {
                    WareHouseId = 2,
                    WareHouseCode = "WH002",
                    City = "Chennai",
                    Country = "India",
                    Latitude = 9.9252009999999995,
                    Longitude = 78.119774000000007,
                    State = "TamilNadu",
                    WareHouseName = "WH_Madurai",
                    CreatedBy = "Sedded_Data",
                    CreatedAt = DateTime.Today.Date,
                    IsDeleted = false
                },
                new WareHouse()
                {
                    WareHouseId = 3,
                    WareHouseCode = "WH003",
                    City = "Chennai",
                    Country = "India",
                    Latitude = 10.790483,
                    Longitude = 78.704673999999997,
                    State = "TamilNadu",
                    WareHouseName = "WH_Tirchy",
                    CreatedBy = "Sedded_Data",
                    CreatedAt = DateTime.Today.Date,
                    IsDeleted = false
                },
                new WareHouse()
                {
                    WareHouseId = 4,
                    WareHouseCode = "WH004",
                    City = "Banglore",
                    Country = "India",
                    Latitude = 12.971598999999999,
                    Longitude = 77.594566,
                    State = "Karantaka",
                    WareHouseName = "WH_Bangalore",
                    CreatedBy = "Sedded_Data",
                    CreatedAt = DateTime.Today.Date,
                    IsDeleted = false
                },
                new WareHouse()
                {
                    WareHouseId = 5,
                    WareHouseCode = "WH005",
                    City = "Hyderabad",
                    Country = "India",
                    Latitude = 17.385044000000001,
                    Longitude = 78.486671000000001,
                    State = "Telangana",
                    WareHouseName = "WH_Hyderabad",
                    CreatedBy = "Sedded_Data",
                    CreatedAt = DateTime.Today.Date,
                    IsDeleted = false
                }
            );
        }
    }
}
