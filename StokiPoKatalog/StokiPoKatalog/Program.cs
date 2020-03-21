using StokiPoKatalog.Models;
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
            //..........
           
        }
    }
}
