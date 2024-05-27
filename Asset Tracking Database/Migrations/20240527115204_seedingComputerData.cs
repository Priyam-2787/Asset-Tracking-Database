using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Asset_Tracking_Database.Migrations
{
    /// <inheritdoc />
    public partial class seedingComputerData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "Id", "Brand", "Currency", "MdelName", "Office", "Price" },
                values: new object[,]
                {
                    { 1, "HP", "EUR", "Elitebook", "Spain", 1423m },
                    { 2, "Asus", "USD", "W234", "USA", 1200m },
                    { 3, "HP", "SEK", "Elitebook", "Sweden", 588m },
                    { 4, "Lenovo", "USD", "Yoga730", "USA", 835m },
                    { 5, "Lenovo", "USD", "Yoga432", "USA", 745m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
