﻿// <auto-generated />
using System;
using BHSystem.API.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BHSystem.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231113052514_initial-v3")]
    partial class initialv3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BHSytem.Models.Entities.BoardingHouses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("Date_Create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Update")
                        .HasColumnType("datetime2");

                    b.Property<int>("Image_Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<int?>("User_Create")
                        .HasColumnType("int");

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.Property<int?>("User_Update")
                        .HasColumnType("int");

                    b.Property<int>("Ward_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Image_Id");

                    b.HasIndex("User_Id");

                    b.HasIndex("Ward_Id");

                    b.ToTable("BoardingHouses");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Bookings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Date_Create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Update")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int>("Room_Id")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("User_Create")
                        .HasColumnType("int");

                    b.Property<int?>("User_Update")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Room_Id");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Citys", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date_Create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Update")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("User_Create")
                        .HasColumnType("int");

                    b.Property<int?>("User_Update")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Citys");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BoardingHouse_Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date_Create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Update")
                        .HasColumnType("datetime2");

                    b.Property<string>("Describe")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Image_Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("User_Create")
                        .HasColumnType("int");

                    b.Property<int?>("User_Update")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BoardingHouse_Id");

                    b.HasIndex("Image_Id");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Distincts", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("City_Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date_Create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Update")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("User_Create")
                        .HasColumnType("int");

                    b.Property<int?>("User_Update")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("City_Id");

                    b.ToTable("Distincts");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Images", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Date_Create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Update")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("User_Create")
                        .HasColumnType("int");

                    b.Property<int?>("User_Update")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.ImagesDetails", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Image_Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date_Create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Update")
                        .HasColumnType("datetime2");

                    b.Property<string>("File_Path")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("User_Create")
                        .HasColumnType("int");

                    b.Property<int?>("User_Update")
                        .HasColumnType("int");

                    b.HasKey("Id", "Image_Id");

                    b.HasIndex("Image_Id");

                    b.ToTable("ImagesDetails");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Menus", b =>
                {
                    b.Property<string>("MenuId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("Date_Create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Update")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Parent")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("User_Create")
                        .HasColumnType("int");

                    b.Property<int?>("User_Update")
                        .HasColumnType("int");

                    b.HasKey("MenuId");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            MenuId = "000-001",
                            Icon = "fa fa-chart-bar",
                            IsDeleted = false,
                            Level = 0,
                            Link = "/admin/report",
                            Name = "Biểu đồ thống kê",
                            Parent = ""
                        },
                        new
                        {
                            MenuId = "000-002",
                            Icon = "fa-solid fa-people-roof",
                            IsDeleted = false,
                            Level = 0,
                            Link = "/admin/boarding-house",
                            Name = "Quản lý phòng trọ",
                            Parent = ""
                        },
                        new
                        {
                            MenuId = "000-003",
                            Icon = "fa-solid fa-user-check",
                            IsDeleted = false,
                            Level = 0,
                            Link = "/admin/approve-room",
                            Name = "Phê duyệt phòng",
                            Parent = ""
                        },
                        new
                        {
                            MenuId = "000-004",
                            Icon = "fa-solid fa-user-pen",
                            IsDeleted = false,
                            Level = 0,
                            Link = "/admin/approve-booking",
                            Name = "Xác nhận đặt phòng",
                            Parent = ""
                        },
                        new
                        {
                            MenuId = "000-005",
                            Icon = "fa-solid fa-users",
                            IsDeleted = false,
                            Level = 0,
                            Link = "/admin/user",
                            Name = "Quản lý người dùng",
                            Parent = ""
                        },
                        new
                        {
                            MenuId = "000-006",
                            Icon = "fa-solid fa-folder-tree",
                            IsDeleted = false,
                            Level = 0,
                            Link = "/admin/role",
                            Name = "Quản lý nhóm quyền",
                            Parent = ""
                        });
                });

            modelBuilder.Entity("BHSytem.Models.Entities.RoleMenus", b =>
                {
                    b.Property<int>("Role_Id")
                        .HasColumnType("int");

                    b.Property<string>("Menu_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("Date_Create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Update")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("User_Create")
                        .HasColumnType("int");

                    b.Property<int?>("User_Update")
                        .HasColumnType("int");

                    b.HasKey("Role_Id", "Menu_Id");

                    b.HasIndex("Menu_Id");

                    b.ToTable("RoleMenus");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Date_Create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Update")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("User_Create")
                        .HasColumnType("int");

                    b.Property<int?>("User_Update")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.RoomPrices", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Room_Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date_Create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Update")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("User_Create")
                        .HasColumnType("int");

                    b.Property<int?>("User_Update")
                        .HasColumnType("int");

                    b.HasKey("Id", "Room_Id");

                    b.HasIndex("Room_Id");

                    b.ToTable("RoomPrices");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Rooms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Boarding_House_Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date_Create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Update")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Image_Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Length")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("User_Create")
                        .HasColumnType("int");

                    b.Property<int?>("User_Update")
                        .HasColumnType("int");

                    b.Property<decimal>("Width")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("Boarding_House_Id");

                    b.HasIndex("Image_Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.UserRoles", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Role_Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date_Create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Update")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("User_Create")
                        .HasColumnType("int");

                    b.Property<int?>("User_Update")
                        .HasColumnType("int");

                    b.HasKey("UserId", "Role_Id");

                    b.HasIndex("Role_Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("Date_Create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Update")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FullName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PasswordReset")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("User_Create")
                        .HasColumnType("int");

                    b.Property<int?>("User_Update")
                        .HasColumnType("int");

                    b.Property<int>("Ward_Id")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("Ward_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Wards", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date_Create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Update")
                        .HasColumnType("datetime2");

                    b.Property<int>("Distincts_Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("User_Create")
                        .HasColumnType("int");

                    b.Property<int?>("User_Update")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Distincts_Id");

                    b.ToTable("Wards");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.BoardingHouses", b =>
                {
                    b.HasOne("BHSytem.Models.Entities.Images", "Images")
                        .WithMany("BoardingHouses")
                        .HasForeignKey("Image_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BHSytem.Models.Entities.Users", "Users")
                        .WithMany("BoardingHouses")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BHSytem.Models.Entities.Wards", "Wards")
                        .WithMany("BoardingHouses")
                        .HasForeignKey("Ward_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Images");

                    b.Navigation("Users");

                    b.Navigation("Wards");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Bookings", b =>
                {
                    b.HasOne("BHSytem.Models.Entities.Rooms", "Rooms")
                        .WithMany("Bookings")
                        .HasForeignKey("Room_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BHSytem.Models.Entities.Users", "Users")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Rooms");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Comments", b =>
                {
                    b.HasOne("BHSytem.Models.Entities.BoardingHouses", "BoardingHouses")
                        .WithMany("Comments")
                        .HasForeignKey("BoardingHouse_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BHSytem.Models.Entities.Images", "Image")
                        .WithMany("Comments")
                        .HasForeignKey("Image_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BHSytem.Models.Entities.Users", "Users")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BoardingHouses");

                    b.Navigation("Image");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Distincts", b =>
                {
                    b.HasOne("BHSytem.Models.Entities.Citys", "Citys")
                        .WithMany("Distincts")
                        .HasForeignKey("City_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Citys");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.ImagesDetails", b =>
                {
                    b.HasOne("BHSytem.Models.Entities.Images", "Image")
                        .WithMany("ImagesDetails")
                        .HasForeignKey("Image_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.RoleMenus", b =>
                {
                    b.HasOne("BHSytem.Models.Entities.Menus", "Menus")
                        .WithMany("RoleMenus")
                        .HasForeignKey("Menu_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BHSytem.Models.Entities.Roles", "Roles")
                        .WithMany("RoleMenus")
                        .HasForeignKey("Role_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menus");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.RoomPrices", b =>
                {
                    b.HasOne("BHSytem.Models.Entities.Rooms", "Rooms")
                        .WithMany("RoomPrices")
                        .HasForeignKey("Room_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Rooms", b =>
                {
                    b.HasOne("BHSytem.Models.Entities.BoardingHouses", "BoardingHouses")
                        .WithMany("Rooms")
                        .HasForeignKey("Boarding_House_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BHSytem.Models.Entities.Images", "Images")
                        .WithMany("Rooms")
                        .HasForeignKey("Image_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BoardingHouses");

                    b.Navigation("Images");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.UserRoles", b =>
                {
                    b.HasOne("BHSytem.Models.Entities.Roles", "Roles")
                        .WithMany("UserRoles")
                        .HasForeignKey("Role_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BHSytem.Models.Entities.Users", "Users")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Roles");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Users", b =>
                {
                    b.HasOne("BHSytem.Models.Entities.Wards", "Wards")
                        .WithMany("Users")
                        .HasForeignKey("Ward_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Wards");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Wards", b =>
                {
                    b.HasOne("BHSytem.Models.Entities.Distincts", "Distincts")
                        .WithMany("Wards")
                        .HasForeignKey("Distincts_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distincts");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.BoardingHouses", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Citys", b =>
                {
                    b.Navigation("Distincts");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Distincts", b =>
                {
                    b.Navigation("Wards");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Images", b =>
                {
                    b.Navigation("BoardingHouses");

                    b.Navigation("Comments");

                    b.Navigation("ImagesDetails");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Menus", b =>
                {
                    b.Navigation("RoleMenus");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Roles", b =>
                {
                    b.Navigation("RoleMenus");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Rooms", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("RoomPrices");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Users", b =>
                {
                    b.Navigation("BoardingHouses");

                    b.Navigation("Bookings");

                    b.Navigation("Comments");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("BHSytem.Models.Entities.Wards", b =>
                {
                    b.Navigation("BoardingHouses");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
