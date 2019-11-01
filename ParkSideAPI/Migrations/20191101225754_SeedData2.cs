using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkSideAPI.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4,
                column: "Area",
                value: "3,372,981.42 acres");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5,
                column: "Area",
                value: "1,013,125.99 acres");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Area", "Coordinates", "Established", "GoverningBody", "Name", "StateLocation", "Website" },
                values: new object[,]
                {
                    { 6, "310,044.36 acres", "43.73°N 110.80°W", 1929, "National Park Service", "Grand Teton Lake National Park", "Wyoming", "https://www.nps.gov/grte/index.htm" },
                    { 7, "325,605.28 acres", "20.72°N 156.17°W", 1916, "National Park Service", "Haleakala National Park", "Hawaii", "https://www.nps.gov/hale/index.htm" },
                    { 8, "790,635.74 acres", "33.79°N 115.90°W", 1994, "National Park Service", "Joshua Tree National Park", "California", "https://www.nps.gov/jotr/index.htm" },
                    { 9, "52,485.17 acres", "37.18°N 108.49°W", 1906, "National Park Service", "Mesa Verde National Park", "Colorado", "https://www.nps.gov/meve/index.htm" },
                    { 10, "504,780.94 acres", "48.70°N 121.20°W", 1968, "National Park Service", "North Cascades National Park", "Washington", "https://www.nps.gov/noca/index.htm" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4,
                column: "Area",
                value: "3,372,981.42  acres");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5,
                column: "Area",
                value: "1,013,125.99  acres");
        }
    }
}
