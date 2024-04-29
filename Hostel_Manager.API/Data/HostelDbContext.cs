using Hostel_Manager.API.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Hostel_Manager.API.Data
{
    public class HostelDbContext : IdentityDbContext
    {
        public HostelDbContext(DbContextOptions<HostelDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Hostel> Hostels { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hostel>()
                .HasOne(h => h.Addresses)
                .WithOne(a => a.Hostles)
                .HasForeignKey<Hostel>(h => h.Hostel_address);
            modelBuilder.Entity<Hostel>()
                .HasOne(h => h.Users)
                .WithMany(u => u.Hostels)
                .HasForeignKey(h => h.Owner);
            modelBuilder.Entity<Room>()
                .HasOne(r => r.Hostels)
                .WithMany(h => h.Rooms)
                .HasForeignKey(r => r.Hostel);
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Users)
                .WithOne(u => u.Comments)
                .HasForeignKey<Comment>(c => c.Comment_Poster);
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Images)
                .WithMany(i => i.Comments)
                .HasForeignKey(c => c.Comment_Image);
            modelBuilder.Entity<Blog>()
                .HasOne(b => b.Users)
                .WithMany(u => u.Blogs)
                .HasForeignKey(b => b.Blog_Poster);
            modelBuilder.Entity<Blog>()
                .HasOne(b => b.Images)
                .WithMany(i => i.Blogs)
                .HasForeignKey(b => b.Blog_Image);
            modelBuilder.Entity<Image>()
                .HasMany(i => i.Comments)
                .WithOne(c => c.Images)
                .HasForeignKey(c => c.Comment_Image);
            modelBuilder.Entity<Image>()
                .HasMany(i => i.Blogs)
                .WithOne(b => b.Images)
                .HasForeignKey(b => b.Blog_Image);
            modelBuilder.Entity<User>()
                .HasMany(r => r.Roles)
                .WithMany(u => u.users)
                .UsingEntity(j => j.ToTable("UserRoles"));
            modelBuilder.Entity<Role>()
                .HasMany(u => u.users)
                .WithMany(r => r.Roles)
                .UsingEntity(j => j.ToTable("UserRoles"));
           /* public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role role { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }*/
        modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Username = "Long Hoang",
                Password = "123456",
                Email = "Hoanglong@gmail.com",
                Phone = "090930239",
            }) ;

            modelBuilder.Entity<User>().HasData(new User
            {
                Id =2,
                Username = "Hoang Hoang",
                Password = "123445",
                Email = "Longvipzz@gmail.com",
                Phone = "0930032"
            });
            /* public int Id { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string Street { get; set; }
        public string Detail { get; set; }*/
            modelBuilder.Entity<Address>().HasData(new Address
            {
                Id = 1,
                City = "Vinh Long",
                District = "Tam Binh",
                Ward = "Song Phu",
                Street = "Nguyen Trai",
                Detail = "So 19/23 Hem 4"
            });
            modelBuilder.Entity<Address>().HasData(new Address
            {
                Id = 2,
                City = "Vinh Long",
                District = "Tam Binh",
                Ward = "Song Phu",
                Street = "Nguyen Trai",
                Detail = "So 19/23 Hem 4"
            });
            modelBuilder.Entity<Address>().HasData(new Address
            {
                Id = 3,
                City = "Vinh Long",
                District = "Tam Binh",
                Ward = "Song Phu",
                Street = "Nguyen Trai",
                Detail = "So 19/23 Hem 4"
            });
            modelBuilder.Entity<Address>().HasData(new Address
            {
                Id = 4,
                City = "Vinh Long",
                District = "Tam Binh",
                Ward = "Song Phu",
                Street = "Nguyen Trai",
                Detail = "So 19/23 Hem 4"
            });
            modelBuilder.Entity<Image>().HasData(new Image
            {
                Id = 1,
                URL_Images = "/img/room-1.jpg"
            });
            /*public int Id { get; set; }
        public string Hostel_name { get; set; }
        public int Hostel_address { get; set; }
        public int Owner { get; set; }
        public string Hostel_discription { get; set; }
        public string Parking { get; set; }
        public int Available { get; set; }
        public int Image_Hostel { get; set; }
        public DateTime Create { get; set; }
        public string Hostel_phone { get; set; }
            */
            modelBuilder.Entity<Hostel>().HasData(new Hostel
            {
                Id = 1,
                Hostel_name = "Nguyen Phat",
                Hostel_address = 1,
                Owner = 1,
                Hostel_discription = "Nha moi xay",
                Parking = "Co",
                Available = 2,
                Image_Hostel = "/img/Room-5.jpg",
                Create = new DateTime(2000, 1, 1),
                Hostel_phone = "0909033"
            });
            modelBuilder.Entity<Hostel>().HasData(new Hostel
            {
                Id = 2,
                Hostel_name = "Nguyen Phat",
                Hostel_address = 2,
                Owner = 2,
                Hostel_discription = "Nha moi xay",
                Parking = "Co",
                Available = 2,
                Image_Hostel = "/img/Room-4.jpg",
                Create = new DateTime(2000, 1, 2),
                Hostel_phone = "09039039"
            });
            modelBuilder.Entity<Hostel>().HasData(new Hostel
            {
                Id = 3,
                Hostel_name = "Nguyen Phat",
                Hostel_address = 3,
                Owner = 2,
                Hostel_discription = "Nha moi xay",
                Parking = "Co",
                Available = 2,
                Image_Hostel = "/img/Room-4.jpg",
                Create = new DateTime(2000, 1, 2),
                Hostel_phone = "09039039"
            });
            modelBuilder.Entity<Hostel>().HasData(new Hostel
            {
                Id = 4,
                Hostel_name = "Nguyen Phat",
                Hostel_address = 4,
                Owner = 2,
                Hostel_discription = "Nha moi xay",
                Parking = "Co",
                Available = 2,
                Image_Hostel = "/img/Room-5.jpg",
                Create = new DateTime(2000, 1, 2),
                Hostel_phone = "09039039"
            });
        }

    }
}
