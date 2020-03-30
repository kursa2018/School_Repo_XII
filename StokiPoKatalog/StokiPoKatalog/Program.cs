using StokiPoKatalog.Models;
using StokiPoKatalog.Presentation;
using System;

namespace StokiPoKatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new CatalogDbContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            //Създаваме инстанция на класа Display
            Display display = new Display();        
        }
    }
}
