using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebInterfaceBd.Models
{
    public partial class avtoBdContext : DbContext
    {
        public avtoBdContext()
        {
        }

        public avtoBdContext(DbContextOptions<avtoBdContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-Q7K8NEA\\SQLEXPRESS;Initial Catalog=avtoBd;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Color).HasMaxLength(20);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.HasKey(e => e.Kola);

                entity.Property(e => e.Kola).ValueGeneratedNever();

                entity.Property(e => e.Adress).HasMaxLength(100);

                entity.Property(e => e.CreditCard).IsRequired();

                entity.Property(e => e.Family)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.KolaNavigation)
                    .WithOne(p => p.Clients)
                    .HasForeignKey<Clients>(d => d.Kola);
            });
        }
    }
}
