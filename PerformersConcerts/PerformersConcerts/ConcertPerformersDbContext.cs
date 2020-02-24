using Microsoft.EntityFrameworkCore;
using PerformersConcerts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PerformersConcerts
{
    public class ConcertPerformersDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Performer> Performers { get; set; }
        public DbSet<Concert> Concerts { get; set; }
    }
}
