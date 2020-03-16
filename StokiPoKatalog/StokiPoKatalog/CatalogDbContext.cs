using Microsoft.EntityFrameworkCore;
using StokiPoKatalog.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StokiPoKatalog
{
    public  class CatalogDbContext:DbContext
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
        {   //Mani-to-Mani RelationShip Create
            modelBuilder.Entity<Product>().HasKey(cd=>new { cd.Clients,cd.Distributors});
            modelBuilder.Entity<Product>()
                .HasOne<Client>(cl => cl.Client)
                .WithMany(p => p.Products)
                .HasForeignKey(cd => cd.Clients);

            modelBuilder.Entity<Product>()
                .HasOne(d => d.Distributor)
                .WithMany(p => p.Products)
                .HasForeignKey(cd => cd.Distributors);
            base.OnModelCreating(modelBuilder);
        }
        DbSet<Client>Clients{get;set;}
        DbSet<Product> Products { get; set; }
        DbSet<Distributor> Distributors { get; set; }
    }
}
