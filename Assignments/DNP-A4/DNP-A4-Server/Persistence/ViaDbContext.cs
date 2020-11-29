using System;
using System.Collections.Generic;
using System.Linq;
using A1_DNP1Y.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace A1_DNP1Y.Persistence
{
    public class ViaDbContext : DbContext
    {
        public DbSet<Family> Families { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Interest> Interest { get; set; }
        public DbSet<ChildInterest> ChildInterest { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                @"Data Source = C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A4\DNP-A4-Server\AssignmentDb.db");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ChildInterest>()
                .HasKey(ci => new {ci.ChildId, ci.InterestId});

            modelBuilder.Entity<ChildInterest>()
                .HasOne(childInterest => childInterest.Interest)
                .WithMany(child => child.ChildInterests)
                .HasForeignKey(childInterest => childInterest.InterestId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChildInterest>()
                .HasOne(childInterest => childInterest.Child)
                .WithMany(child => child.ChildInterests)
                .HasForeignKey(childInterest => childInterest.ChildId)
                .OnDelete(DeleteBehavior.Cascade);

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Cascade;
            }
        }
    }
}