using avtopark.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace avtopark
{
    public class AvtosalovDbContext:DbContext
    {      public DbSet<Car> Cars { get; set; }
           public DbSet<Client> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Connection.Conection);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasOne(c => c.Client)
                .WithOne(cl => cl.Car)
                .HasForeignKey<Client>(cl => cl.CarOnLoan);
            base.OnModelCreating(modelBuilder);
        }
    }
}
