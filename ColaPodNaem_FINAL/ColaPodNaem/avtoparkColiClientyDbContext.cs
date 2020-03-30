using ColaPodNaem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColaPodNaem
{
    public class avtoparkColiClientyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Connection.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
        //...............
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasOne(c => c.Client)
                .WithOne(cl => cl.Car)
                .HasForeignKey<Client>("Kola");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
