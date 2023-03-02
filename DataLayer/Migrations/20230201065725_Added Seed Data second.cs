using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class AddedSeedDatasecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "whm",
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryCode", "Categoryname", "CreatedAt", "CreatedBy", "IsDeleted", "ModifiedAt", "ModifiedBy" },
                values: new object[] { 12, "asd", "asd", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "Sedded_Dasdata", false, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12);
        }
    }
}
