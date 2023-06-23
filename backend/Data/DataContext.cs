using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using backend.Models;
using Microsoft.Build.Exceptions;

namespace backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<AppUser> AppUser { get; set; } = default!;

        public DbSet<AppUserProject> AppUserProject { get; set; } = default!;

        public DbSet<Group> Group { get; set; } = default!;

        public DbSet<Project> Project { get; set; } = default!;

        public DbSet<Todo> Todo { get; set; } = default!;
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
            base.OnModelCreating(builder);
        }
    }
}