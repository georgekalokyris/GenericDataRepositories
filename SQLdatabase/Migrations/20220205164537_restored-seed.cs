using Microsoft.EntityFrameworkCore.Migrations;

namespace SQLdatabase.Migrations
{
    public partial class restoredseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "AreaCode", "Name", "countryId" },
                values: new object[] { 1, "000", "Dream City", null });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "AreaCode", "Name", "countryId" },
                values: new object[] { 2, "666", "Gotham City", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
