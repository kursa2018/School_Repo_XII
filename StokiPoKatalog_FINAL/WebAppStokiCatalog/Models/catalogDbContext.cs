using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppStokiCatalog.Models
{
    public partial class catalogDbContext : DbContext
    {
        public catalogDbContext()
        {
        }

        public catalogDbContext(DbContextOptions<catalogDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Distributors> Distributors { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=catalogDb;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>(entity =>
            {
                entity.HasKey(e => e.Egn);

                entity.Property(e => e.Egn).ValueGeneratedNever();

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Distributors>(entity =>
            {
                entity.HasKey(e => e.DistrId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TelContact).IsRequired();
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => new { e.Clients, e.Distributors });

                entity.HasIndex(e => e.Distributors);

                entity.Property(e => e.Naimenovanie)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.ClientsNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Clients);

                entity.HasOne(d => d.DistributorsNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Distributors);
            });
        }
    }
}
