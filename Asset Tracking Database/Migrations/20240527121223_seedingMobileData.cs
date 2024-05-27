using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Asset_Tracking_Database.Migrations
{
    /// <inheritdoc />
    public partial class seedingMobileData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Mobiles",
                columns: new[] { "Id", "Brand", "Currency", "MdelName", "Office", "Price" },
                values: new object[,]
                {
                    { 1, "iphone", "EUR", "8", "Spain", 970m },
                    { 2, "iphone", "EUR", "11", "Spain", 990m },
                    { 3, "iphone", "SEK", "x", "Sweden", 970m },
                    { 4, "Motorola", "SEK", "Razer", "Sweden", 970m },
                    { 5, "Motorola", "SEK", "G", "Sweden", 870m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mobiles",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
