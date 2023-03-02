using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                schema: "whm",
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryCode", "Categoryname", "CreatedAt", "CreatedBy", "IsDeleted", "ModifiedAt", "ModifiedBy" },
                values: new object[] { 11, "CAT0011", "NewDATA", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "Sedded_Data", false, null, null });

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11);

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "whm",
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
