using Enco.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enco.Infrastructure.DbContexts
{
    public class TeamsContext : DbContext
    {
        public TeamsContext(DbContextOptions<TeamsContext> options) : base(options)
        {
            
        }
        public DbSet<Team> Teams { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //DBSeed
            modelBuilder.Entity<Team>().HasData(new Team() {Name = "Mercedes-Benz", DateFounded = new DateTime(1984, 5, 10), WCCount = 2, FeesPaid = true });
            modelBuilder.Entity<Team>().HasData(new Team() {Name = "Ferrari", DateFounded = new DateTime(1978, 4, 6), WCCount = 1, FeesPaid = true });
            modelBuilder.Entity<Team>().HasData(new Team() {Name = "Red Bull", DateFounded = new DateTime(1991, 1, 20), WCCount = 4, FeesPaid = true });
            modelBuilder.Entity<Team>().HasData(new Team() {Name = "Kalanyos-Ciggersz", DateFounded = new DateTime(2005, 3, 15), WCCount = 0, FeesPaid = false });


        }

    }
}
