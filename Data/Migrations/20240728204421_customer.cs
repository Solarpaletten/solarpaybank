using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e92c4c1-f4e0-4b1b-9164-9fcdd6263ebb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2551bc4-b6dd-4dd0-8156-4f037ecde1c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9f56451-8db3-4015-a867-c74d49b856fc");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Juridical = table.Column<bool>(type: "bit", nullable: false),
                    debt = table.Column<bool>(type: "bit", nullable: false),
                    Foreigner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VATCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostOffice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayThrough = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EORI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foreign = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VATrate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8e92c4c1-f4e0-4b1b-9164-9fcdd6263ebb", "3", "Accountant", "Accountant" },
                    { "b2551bc4-b6dd-4dd0-8156-4f037ecde1c5", "2", "Manager", "Manager" },
                    { "c9f56451-8db3-4015-a867-c74d49b856fc", "4", "Client", "Client" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9eb72a27-b7c1-4b15-8267-9b0d43b945c5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3b4a4ac-0b52-45c0-80b1-51e0bd2a7ddb", "AQAAAAIAAYagAAAAELX6DK4rjWxFBmv6B8uacRSnGIZJLYHpudKGXb5I1DmFpYGVY695L/PNkMMt1QhFXQ==", "088350e3-88f1-4f82-af35-0782bbc0ab2d" });
        }
    }
}
