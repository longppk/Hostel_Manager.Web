using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hostel_Manager.API.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hostels_Images_Image_Hostel",
                table: "Hostels");

            migrationBuilder.DropIndex(
                name: "IX_Hostels_Image_Hostel",
                table: "Hostels");

            migrationBuilder.AlterColumn<string>(
                name: "Image_Hostel",
                table: "Hostels",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Hostels",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Hostels_ImageId",
                table: "Hostels",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hostels_Images_ImageId",
                table: "Hostels",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hostels_Images_ImageId",
                table: "Hostels");

            migrationBuilder.DropIndex(
                name: "IX_Hostels_ImageId",
                table: "Hostels");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Hostels");

            migrationBuilder.AlterColumn<int>(
                name: "Image_Hostel",
                table: "Hostels",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image_Hostel",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image_Hostel",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Hostels_Image_Hostel",
                table: "Hostels",
                column: "Image_Hostel");

            migrationBuilder.AddForeignKey(
                name: "FK_Hostels_Images_Image_Hostel",
                table: "Hostels",
                column: "Image_Hostel",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
