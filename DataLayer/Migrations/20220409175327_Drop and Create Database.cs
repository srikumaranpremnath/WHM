using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class DropandCreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "whm");

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "whm",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoryname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "whm",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Mobile = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "WareHouses",
                schema: "whm",
                columns: table => new
                {
                    WareHouseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WareHouseName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WareHouseCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WareHouses", x => x.WareHouseId);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                schema: "whm",
                columns: table => new
                {
                    SubCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubCategoryCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoryID);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalSchema: "whm",
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "whm",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PricePerProduct = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufactureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubCategoryID = table.Column<int>(type: "int", nullable: false),
                    WareHouseID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryID",
                        column: x => x.SubCategoryID,
                        principalSchema: "whm",
                        principalTable: "SubCategories",
                        principalColumn: "SubCategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_WareHouses_WareHouseID",
                        column: x => x.WareHouseID,
                        principalSchema: "whm",
                        principalTable: "WareHouses",
                        principalColumn: "WareHouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "whm",
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryCode", "Categoryname", "CreatedAt", "CreatedBy", "IsDeleted", "ModifiedAt", "ModifiedBy" },
                values: new object[,]
                {
                    { 1, "CAT001", "Electronics", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sedded_Data", false, null, null },
                    { 2, "CAT002", "Electricals", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sedded_Data", false, null, null },
                    { 3, "CAT003", "Furnitures", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sedded_Data", false, null, null },
                    { 4, "CAT004", "Machines", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sedded_Data", false, null, null },
                    { 5, "CAT005", "FootWear", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sedded_Data", false, null, null },
                    { 6, "CAT006", "Medical Equipments", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sedded_Data", false, null, null },
                    { 7, "CAT007", "Appliances", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sedded_Data", false, null, null },
                    { 8, "CAT008", "Beauty Products", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sedded_Data", false, null, null },
                    { 9, "CAT009", "Fitness", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sedded_Data", false, null, null },
                    { 10, "CAT010", "Toys", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sedded_Data", false, null, null }
                });

            migrationBuilder.InsertData(
                schema: "whm",
                table: "WareHouses",
                columns: new[] { "WareHouseId", "City", "Country", "CreatedAt", "CreatedBy", "IsDeleted", "Latitude", "Longitude", "ModifiedAt", "ModifiedBy", "State", "WareHouseCode", "WareHouseName" },
                values: new object[,]
                {
                    { 1, "Chennai", "India", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sedded_Data", false, 13.08268, 80.270720999999995, null, null, "TamilNadu", "WH001", "WH_Chennai" },
                    { 2, "Chennai", "India", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sedded_Data", false, 9.9252009999999995, 78.119774000000007, null, null, "TamilNadu", "WH002", "WH_Madurai" },
                    { 3, "Chennai", "India", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sedded_Data", false, 10.790483, 78.704673999999997, null, null, "TamilNadu", "WH003", "WH_Tirchy" },
                    { 4, "Banglore", "India", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sedded_Data", false, 12.971598999999999, 77.594566, null, null, "Karantaka", "WH004", "WH_Bangalore" },
                    { 5, "Hyderabad", "India", new DateTime(2022, 4, 9, 0, 0, 0, 0, DateTimeKind.Local), "Sedded_Data", false, 17.385044000000001, 78.486671000000001, null, null, "Telangana", "WH005", "WH_Hyderabad" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryCode_Categoryname_IsDeleted",
                schema: "whm",
                table: "Categories",
                columns: new[] { "CategoryCode", "Categoryname", "IsDeleted" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCode_SubCategoryID_PricePerProduct",
                schema: "whm",
                table: "Products",
                columns: new[] { "ProductCode", "SubCategoryID", "PricePerProduct" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryID",
                schema: "whm",
                table: "Products",
                column: "SubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_WareHouseID",
                schema: "whm",
                table: "Products",
                column: "WareHouseID");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryID",
                schema: "whm",
                table: "SubCategories",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_SubCategoryCode_SubCategoryname_IsDeleted",
                schema: "whm",
                table: "SubCategories",
                columns: new[] { "SubCategoryCode", "SubCategoryname", "IsDeleted" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email_IsDeleted",
                schema: "whm",
                table: "Users",
                columns: new[] { "Email", "IsDeleted" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Mobile_IsDeleted",
                schema: "whm",
                table: "Users",
                columns: new[] { "Mobile", "IsDeleted" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName_IsDeleted",
                schema: "whm",
                table: "Users",
                columns: new[] { "UserName", "IsDeleted" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WareHouses_WareHouseCode_WareHouseName_IsDeleted",
                schema: "whm",
                table: "WareHouses",
                columns: new[] { "WareHouseCode", "WareHouseName", "IsDeleted" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products",
                schema: "whm");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "whm");

            migrationBuilder.DropTable(
                name: "SubCategories",
                schema: "whm");

            migrationBuilder.DropTable(
                name: "WareHouses",
                schema: "whm");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "whm");
        }
    }
}
