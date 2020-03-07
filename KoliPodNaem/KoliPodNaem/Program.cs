using System;

namespace KoliPodNaem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Създаваме контекст
            var context = new carsClientsDbContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
