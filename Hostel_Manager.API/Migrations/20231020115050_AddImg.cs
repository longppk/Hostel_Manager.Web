using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hostel_Manager.API.Migrations
{
    public partial class AddImg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image_Hostel",
                value: "/img/Room-5.jpg");

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image_Hostel",
                value: "/img/Room-4.jpg");

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image_Hostel",
                value: "/img/Room-4.jpg");

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image_Hostel",
                value: "/img/Room-5.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image_Hostel",
                value: "/img/carousel-1.jpg");

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image_Hostel",
                value: "/img/carousel-1.jpg");

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image_Hostel",
                value: "/img/carousel-1.jpg");

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image_Hostel",
                value: "/img/carousel-1.jpg");
        }
    }
}
