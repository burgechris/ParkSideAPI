using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkSideAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Area", "Coordinates", "Established", "GoverningBody", "Name", "StateLocation", "Website" },
                values: new object[,]
                {
                    { 2, "49,075.26 acres", "44.35°N 68.21°W", 1919, "National Park Service", "Acadia National Park", "Maine", "https://www.nps.gov/acad/index.htm" },
                    { 3, "183,224.05 acres", "42.94°N 122.1°W", 1902, "National Park Service", "Crater Lake National Park", "Oregon", "https://www.nps.gov/crla/index.htm" },
                    { 4, "3,372,981.42  acres", "36.24°N 116.82°W", 1994, "National Park Service", "Death Valley Lake National Park", "California", "https://www.nps.gov/deva/index.htm" },
                    { 5, "1,013,125.99  acres", "48.80°N 114.00°W", 1910, "National Park Service", "Glacier Lake National Park", "Montana", "https://www.nps.gov/glac/index.htm" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);
        }
    }
}
