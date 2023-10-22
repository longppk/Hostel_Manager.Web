using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hostel_Manager.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ward = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URL_Images = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Blog_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Blog_Image = table.Column<int>(type: "int", nullable: false),
                    Blog_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Blog_Poster = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Images_Blog_Image",
                        column: x => x.Blog_Image,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blogs_Users_Blog_Poster",
                        column: x => x.Blog_Poster,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment_Image = table.Column<int>(type: "int", nullable: false),
                    Comment_Poster = table.Column<int>(type: "int", nullable: false),
                    Comment_Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Images_Comment_Image",
                        column: x => x.Comment_Image,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_Comment_Poster",
                        column: x => x.Comment_Poster,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hostels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hostel_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hostel_address = table.Column<int>(type: "int", nullable: false),
                    Owner = table.Column<int>(type: "int", nullable: false),
                    Hostel_discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parking = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Available = table.Column<int>(type: "int", nullable: false),
                    Image_Hostel = table.Column<int>(type: "int", nullable: false),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hostel_phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hostels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hostels_Addresses_Hostel_address",
                        column: x => x.Hostel_address,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hostels_Images_Image_Hostel",
                        column: x => x.Image_Hostel,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hostels_Users_Owner",
                        column: x => x.Owner,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hostel = table.Column<int>(type: "int", nullable: false),
                    Room_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Electric = table.Column<float>(type: "real", nullable: false),
                    Water = table.Column<float>(type: "real", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Hostels_Hostel",
                        column: x => x.Hostel,
                        principalTable: "Hostels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Detail", "District", "Street", "Ward" },
                values: new object[,]
                {
                    { 1, "Vinh Long", "So 19/23 Hem 4", "Tam Binh", "Nguyen Trai", "Song Phu" },
                    { 2, "Vinh Long", "So 19/23 Hem 4", "Tam Binh", "Nguyen Trai", "Song Phu" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "URL_Images" },
                values: new object[] { 1, "../anh" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Phone", "Username", "role" },
                values: new object[,]
                {
                    { 1, "Hoanglong@gmail.com", "123456", "090930239", "Long Hoang", 2 },
                    { 2, "Longvipzz@gmail.com", "123445", "0930032", "Hoang Hoang", 0 }
                });

            migrationBuilder.InsertData(
                table: "Hostels",
                columns: new[] { "Id", "Available", "Create", "Hostel_address", "Hostel_discription", "Hostel_name", "Hostel_phone", "Image_Hostel", "Owner", "Parking" },
                values: new object[] { 1, 2, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nha moi xay", "Nguyen Phat", "0909033", 1, 1, "Co" });

            migrationBuilder.InsertData(
                table: "Hostels",
                columns: new[] { "Id", "Available", "Create", "Hostel_address", "Hostel_discription", "Hostel_name", "Hostel_phone", "Image_Hostel", "Owner", "Parking" },
                values: new object[] { 2, 2, new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Nha moi xay", "Nguyen Phat", "09039039", 1, 2, "Co" });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Blog_Image",
                table: "Blogs",
                column: "Blog_Image");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Blog_Poster",
                table: "Blogs",
                column: "Blog_Poster");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Comment_Image",
                table: "Comments",
                column: "Comment_Image");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Comment_Poster",
                table: "Comments",
                column: "Comment_Poster",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hostels_Hostel_address",
                table: "Hostels",
                column: "Hostel_address",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hostels_Image_Hostel",
                table: "Hostels",
                column: "Image_Hostel");

            migrationBuilder.CreateIndex(
                name: "IX_Hostels_Owner",
                table: "Hostels",
                column: "Owner");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Hostel",
                table: "Rooms",
                column: "Hostel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Hostels");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
