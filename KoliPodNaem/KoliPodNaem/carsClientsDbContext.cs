using KoliPodNaem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KoliPodNaem
{
    public class carsClientsDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Connection.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   //Да се оправи връзката едно-към едно
           

            base.OnModelCreating(modelBuilder);
        }
        //Таблици в базата от данни
        public DbSet<Car> Cars { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
