using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkSideAPI.Migrations
{
    public partial class addSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Area", "Coordinates", "Established", "GoverningBody", "Name", "StateLocation", "Website" },
                values: new object[] { 1, "2,219,791 acres", "44°36′N 110°30′W", 1872, "National Park Service", "Yellowstone National Park", "Wyoming", "https://www.nps.gov/yell/index.htm" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);
        }
    }
}
