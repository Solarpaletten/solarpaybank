using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class adreadnbank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b77410c-206a-4a24-a5ce-0f846dde0b30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93cc348c-bfe7-40f1-8831-4925e45d2e11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb892ef7-efeb-4f74-89c9-e0eb0e1c7930");

            migrationBuilder.CreateTable(
                name: "CustomerAddresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registration = table.Column<bool>(type: "bit", nullable: false),
                    Correspondence = table.Column<bool>(type: "bit", nullable: false),
                    Loading = table.Column<bool>(type: "bit", nullable: false),
                    Unloading = table.Column<bool>(type: "bit", nullable: false),
                    Divid = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAddresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerBanks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SwiftCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBanks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerBanks_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02a055ac-f549-43c4-8cb9-ef7ec75aaee9", "4", "Client", "Client" },
                    { "3b3426b2-e94e-4fe2-a998-e433ba21480f", "3", "Accountant", "Accountant" },
                    { "f81ad39a-fc50-46db-be1a-3d84bf068693", "2", "Manager", "Manager" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9eb72a27-b7c1-4b15-8267-9b0d43b945c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "432c1951-ee73-40a2-b287-6d0beb643a47", "AQAAAAIAAYagAAAAEHBLNH7ZxJYVsKVPIOEj2ZaQO9SmyNPrpUdHAoWzSIFJ83ER3Dy8h+dMsNJP71RKgQ==", "2770b211-7b44-43dd-80d0-2a9fe1d825f2" });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_CustomerId",
                table: "CustomerAddresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBanks_CustomerId",
                table: "CustomerBanks",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerAddresses");

            migrationBuilder.DropTable(
                name: "CustomerBanks");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02a055ac-f549-43c4-8cb9-ef7ec75aaee9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b3426b2-e94e-4fe2-a998-e433ba21480f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f81ad39a-fc50-46db-be1a-3d84bf068693");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6b77410c-206a-4a24-a5ce-0f846dde0b30", "2", "Manager", "Manager" },
                    { "93cc348c-bfe7-40f1-8831-4925e45d2e11", "3", "Accountant", "Accountant" },
                    { "bb892ef7-efeb-4f74-89c9-e0eb0e1c7930", "4", "Client", "Client" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9eb72a27-b7c1-4b15-8267-9b0d43b945c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4ffc742-286b-4e36-8711-d07a2ee2cde9", "AQAAAAIAAYagAAAAEEMKEXntbTWaNcyFXjvt5KpjYQlrPaVnM1VTRwCMVMY2Lnp75ZNZMISA106tulwyDg==", "23e689dc-0082-4b85-8499-bccf850c0673" });
        }
    }
}
