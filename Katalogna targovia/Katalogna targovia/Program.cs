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

        }
    }
}
