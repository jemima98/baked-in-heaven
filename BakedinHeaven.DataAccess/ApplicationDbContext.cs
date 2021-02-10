using BakedinHeaven.DataAccess.Entities;
using BakedinHeaven1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakedinHeaven.DataAccess
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Host=localhost;Database=BakedinHeavenDb;Username=postgres;Password=Slgj@2132";
            optionsBuilder.UseNpgsql(connectionString);

        }
    }
}