using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AngularDemoSeeds.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pincode = table.Column<int>(type: "int", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerMasters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMasters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerMasterId = table.Column<int>(type: "int", nullable: false),
                    TotalOrderAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderMasters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderMasters_CustomerMasters_CustomerMasterId",
                        column: x => x.CustomerMasterId,
                        principalTable: "CustomerMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetailMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderMasterId = table.Column<int>(type: "int", nullable: false),
                    ProductMasterId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetailMasters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetailMasters_OrderMasters_OrderMasterId",
                        column: x => x.OrderMasterId,
                        principalTable: "OrderMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetailMasters_ProductMasters_ProductMasterId",
                        column: x => x.ProductMasterId,
                        principalTable: "ProductMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CustomerMasters",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "CustomerName", "DeletedBy", "DeletedDate", "District", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedDate", "PhoneNumber", "Pincode" },
                values: new object[,]
                {
                    { 1, "Customer 1", 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(452), "Customer 1", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer 1", true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9876543210", 1 },
                    { 2, "Customer 2", 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(456), "Customer 2", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer 2", true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9876543210", 2 },
                    { 3, "Customer 3", 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(459), "Customer 3", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer 3", true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9876543210", 3 },
                    { 4, "Customer 4", 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(461), "Customer 4", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer 4", true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9876543210", 4 },
                    { 5, "Customer 5", 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(463), "Customer 5", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer 5", true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9876543210", 5 },
                    { 6, "Customer 6", 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(465), "Customer 6", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer 6", true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9876543210", 6 },
                    { 7, "Customer 7", 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(467), "Customer 7", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer 7", true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9876543210", 7 },
                    { 8, "Customer 8", 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(469), "Customer 8", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer 8", true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9876543210", 8 },
                    { 9, "Customer 9", 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(471), "Customer 9", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer 9", true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9876543210", 9 },
                    { 10, "Customer 10", 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(473), "Customer 10", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer 10", true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9876543210", 10 },
                    { 11, "Customer 11", 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(475), "Customer 11", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer 11", true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9876543210", 11 },
                    { 12, "Customer 12", 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(478), "Customer 12", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer 12", true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9876543210", 12 },
                    { 13, "Customer 13", 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(480), "Customer 13", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer 13", true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9876543210", 13 },
                    { 14, "Customer 14", 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(482), "Customer 14", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer 14", true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9876543210", 14 },
                    { 15, "Customer 15", 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(484), "Customer 15", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer 15", true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9876543210", 15 }
                });

            migrationBuilder.InsertData(
                table: "ProductMasters",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedDate", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(197), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.15m, "Product 1" },
                    { 2, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(216), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m, "Product 2" },
                    { 3, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(219), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 92.5m, "Product 3" },
                    { 4, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(221), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24.25m, "Product 4" },
                    { 5, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(224), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27.89m, "Product 5" },
                    { 6, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(226), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 610m, "Product 6" },
                    { 7, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(228), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000.16m, "Product 7" },
                    { 8, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(230), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85.74m, "Product 8" },
                    { 9, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(232), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 52.5m, "Product 9" },
                    { 10, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(235), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 66.79m, "Product 10" },
                    { 11, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(237), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.95m, "Product 11" },
                    { 12, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(250), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 63.67m, "Product 12" },
                    { 13, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(252), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 69.69m, "Product 13" },
                    { 14, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(254), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 69.17m, "Product 14" },
                    { 15, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(257), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.42m, "Product 15" }
                });

            migrationBuilder.InsertData(
                table: "OrderMasters",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerMasterId", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedDate", "TotalOrderAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(507), 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.15m },
                    { 2, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(511), 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20m },
                    { 3, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(514), 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 92.5m },
                    { 4, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(516), 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24.25m },
                    { 5, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(518), 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27.89m },
                    { 6, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(520), 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 610m },
                    { 7, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(522), 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000.16m },
                    { 8, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(524), 8, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 85.74m },
                    { 9, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(526), 9, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 52.5m },
                    { 10, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(528), 10, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 78.94m },
                    { 11, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(530), 11, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38.95m },
                    { 12, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(532), 12, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 156.17m },
                    { 13, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(534), 13, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 139.38m },
                    { 14, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(536), 14, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 138.34m },
                    { 15, 1, new DateTime(2023, 3, 28, 16, 27, 4, 170, DateTimeKind.Local).AddTicks(538), 15, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34.84m }
                });

            migrationBuilder.InsertData(
                table: "OrderDetailMasters",
                columns: new[] { "Id", "OrderMasterId", "ProductMasterId", "Quantity", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 12.15m },
                    { 2, 2, 2, 1, 20m },
                    { 3, 3, 3, 1, 92.5m },
                    { 4, 4, 4, 1, 24.25m },
                    { 5, 5, 5, 1, 27.89m },
                    { 6, 6, 6, 1, 610m },
                    { 7, 7, 7, 1, 1000.16m },
                    { 8, 8, 8, 1, 85.74m },
                    { 9, 9, 9, 1, 52.5m },
                    { 10, 10, 10, 1, 66.79m },
                    { 11, 11, 11, 1, 18.95m },
                    { 12, 12, 12, 1, 63.67m },
                    { 13, 13, 13, 2, 139.38m },
                    { 14, 14, 14, 2, 138.34m },
                    { 15, 15, 15, 2, 34.84m },
                    { 16, 10, 1, 1, 12.15m },
                    { 17, 11, 2, 1, 20m },
                    { 18, 12, 3, 1, 92.5m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetailMasters_OrderMasterId",
                table: "OrderDetailMasters",
                column: "OrderMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetailMasters_ProductMasterId",
                table: "OrderDetailMasters",
                column: "ProductMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderMasters_CustomerMasterId",
                table: "OrderMasters",
                column: "CustomerMasterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetailMasters");

            migrationBuilder.DropTable(
                name: "OrderMasters");

            migrationBuilder.DropTable(
                name: "ProductMasters");

            migrationBuilder.DropTable(
                name: "CustomerMasters");
        }
    }
}
