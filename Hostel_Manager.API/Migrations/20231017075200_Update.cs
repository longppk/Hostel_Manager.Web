using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hostel_Manager.API.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "URL_Images",
                value: "/img/room-1.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "URL_Images",
                value: "../anh");
        }
    }
}
