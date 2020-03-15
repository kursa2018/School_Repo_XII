using Katalogna_targovia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Katalogna_targovia
{
    public class KatalognaTargoviaDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Connection.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Дефиниране на връзки между таблиците!
            modelBuilder.Entity<Client>()
                .HasMany<Product>(p => p.Products)
                .WithOne(c => c.Client)
                .HasForeignKey("KlientId");

           
                
            modelBuilder.Entity<Distributor>()
                .HasMany<Product>(p => p.Products)
                .WithOne(d => d.Distributor)
                .HasForeignKey(" DistributorId");
            base.OnModelCreating(modelBuilder);
        }
        //=============
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Distributor> Distributors { get; set; }
    }
}
