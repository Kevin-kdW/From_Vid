using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using backend.Models;
using Microsoft.Build.Exceptions;
using API.Models;

namespace backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; } = default!;

        public DbSet<AppUserProject> AppUserProjects { get; set; } = default!;

        public DbSet<Group> Group { get; set; } = default!;

        public DbSet<Project> Projects { get; set; } = default!;

        public DbSet<Todo> Todo { get; set; } = default!;
        public DbSet<API.Models.Sock> Sock { get; set; } = default!;
        public DbSet<API.Models.SockShop> SockShop { get; set; } = default!;
        public DbSet<API.Models.SockManufacturer> SockManufacturer { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Group>().HasData(
                new Group
                {
                    Id = 1,
                    Name = "admin"
                },
                new Group
                {
                    Id = 2,
                    Name = "user"
                }
            );
            builder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = 1,
                    GroupId = 1,
                    Username = "admin",
                    Password = "admin",
                },
                new AppUser
                {
                    Id = 2,
                    GroupId = 2,
                    Username = "user",
                    Password = "user",
                }
            );
            builder.Entity<Sock>().HasData(
                new Sock
                {
                    Id = 1,
                    Name = "Sock",
                    Brand = "Adidas",
                },
                new Sock
                {
                    Id = 2,
                    Name = "Sockie",
                    Brand = "Brandy",
                });
            builder.Entity<SockManufacturer>().HasData(
                new SockManufacturer
                {
                    Id = 1,
                    Name = "Inver Sock",
                    Location = "Invercargill",
                    SockId = 1,
                },
                new SockManufacturer
                {
                    Id = 2,
                    Name = "Dunnerz sockz",
                    Location = "Dunedin",
                    SockId = 2,
                }
            );
            builder.Entity<SockShop>().HasData(
                new SockShop
                {
                    Id = 1,
                    Name = "Sock shopppp",
                },
                new SockShop
                {
                    Id = 2,
                    Name = "Swag Socks"
                }
            );

            base.OnModelCreating(builder);
        }


    }
}