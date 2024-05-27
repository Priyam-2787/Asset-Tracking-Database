using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asset_Tracking_Database.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataComputerMobileTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ComputerMobile",
                columns: new[] { "ComputerListId", "MobileListId" },
                values: new object[] { 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ComputerMobile",
                keyColumns: new[] { "ComputerListId", "MobileListId" },
                keyValues: new object[] { 1, 1 });
        }
    }
}
