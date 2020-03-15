using Katalogna_targovia.Models;
using System;

namespace Katalogna_targovia
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new KatalognaTargoviaDbContext();
            //-------------
           
            //---------------
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            Client c1 = new Client();
            c1.Name = "Стефан Папанов";
            c1.Egn = "6608203584";
            c1.Adress = "Пионерска 36";
            c1.Tel = "5-1234";
            context.Add(c1);
            context.SaveChanges();
            //........................
            Client c2 = new Client();
            c2.Name = "Георги Иванов";
            c2.Egn = "6608666645";
            c2.Adress = "Кристал 12";
            c2.Tel = "5-4589";
            context.Add(c2);
            context.SaveChanges();
        }
    }
}
