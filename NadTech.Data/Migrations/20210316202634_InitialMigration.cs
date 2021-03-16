using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NadTech.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Street = table.Column<string>(type: "TEXT", nullable: true),
                    PostCode = table.Column<string>(type: "TEXT", nullable: true),
                    HouseNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    AddressId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    CustomerId = table.Column<Guid>(type: "TEXT", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "DateCreated", "DateModified", "HouseNumber", "IsDeleted", "PostCode", "Street" },
                values: new object[] { 1, new DateTime(2021, 3, 16, 21, 26, 33, 619, DateTimeKind.Local).AddTicks(7545), new DateTime(2021, 3, 16, 21, 26, 33, 619, DateTimeKind.Local).AddTicks(7549), 41, false, "112001", "Lawn Street" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "DateCreated", "DateModified", "HouseNumber", "IsDeleted", "PostCode", "Street" },
                values: new object[] { 2, new DateTime(2021, 3, 16, 21, 26, 33, 619, DateTimeKind.Local).AddTicks(8352), new DateTime(2021, 3, 16, 21, 26, 33, 619, DateTimeKind.Local).AddTicks(8352), 34, false, "1234201", "Test2 Street" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "DateCreated", "DateModified", "HouseNumber", "IsDeleted", "PostCode", "Street" },
                values: new object[] { 3, new DateTime(2021, 3, 16, 21, 26, 33, 619, DateTimeKind.Local).AddTicks(8357), new DateTime(2021, 3, 16, 21, 26, 33, 619, DateTimeKind.Local).AddTicks(8358), 24, false, "100001", "Test Street" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "DateCreated", "DateModified", "HouseNumber", "IsDeleted", "PostCode", "Street" },
                values: new object[] { 4, new DateTime(2021, 3, 16, 21, 26, 33, 619, DateTimeKind.Local).AddTicks(8362), new DateTime(2021, 3, 16, 21, 26, 33, 619, DateTimeKind.Local).AddTicks(8362), 24, false, "100001", "Test Street" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddressId", "Age", "DateCreated", "DateModified", "FirstName", "Gender", "IsDeleted", "LastName" },
                values: new object[] { new Guid("1ca9aba0-ce96-4250-9897-5347aa7102a3"), 1, new DateTime(1991, 3, 16, 21, 26, 33, 621, DateTimeKind.Local).AddTicks(6831), new DateTime(2021, 3, 16, 21, 26, 33, 621, DateTimeKind.Local).AddTicks(5741), new DateTime(2021, 3, 16, 21, 26, 33, 621, DateTimeKind.Local).AddTicks(5765), "Jane", 2, false, "Doe" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddressId", "Age", "DateCreated", "DateModified", "FirstName", "Gender", "IsDeleted", "LastName" },
                values: new object[] { new Guid("d91221fb-3795-4a07-aabd-6c47d5129ab2"), 2, new DateTime(1998, 3, 16, 21, 26, 33, 622, DateTimeKind.Local).AddTicks(775), new DateTime(2021, 3, 16, 21, 26, 33, 622, DateTimeKind.Local).AddTicks(751), new DateTime(2021, 3, 16, 21, 26, 33, 622, DateTimeKind.Local).AddTicks(764), "Bash", 1, false, "Ali" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddressId", "Age", "DateCreated", "DateModified", "FirstName", "Gender", "IsDeleted", "LastName" },
                values: new object[] { new Guid("0ad339a2-38c2-466d-9261-9bfd12314e4a"), 3, new DateTime(2003, 3, 16, 21, 26, 33, 622, DateTimeKind.Local).AddTicks(786), new DateTime(2016, 3, 16, 21, 26, 33, 622, DateTimeKind.Local).AddTicks(787), new DateTime(2021, 3, 16, 21, 26, 33, 622, DateTimeKind.Local).AddTicks(784), "Shina", 1, false, "Peters" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddressId", "Age", "DateCreated", "DateModified", "FirstName", "Gender", "IsDeleted", "LastName" },
                values: new object[] { new Guid("44922aed-c036-4aa8-a4af-04a9ec0a21e4"), 4, new DateTime(1986, 3, 16, 21, 26, 33, 622, DateTimeKind.Local).AddTicks(792), new DateTime(2021, 3, 16, 21, 26, 33, 622, DateTimeKind.Local).AddTicks(790), new DateTime(2021, 3, 16, 21, 26, 33, 622, DateTimeKind.Local).AddTicks(791), "Victor", 1, false, "Ifeanyi" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressId",
                table: "Customers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
