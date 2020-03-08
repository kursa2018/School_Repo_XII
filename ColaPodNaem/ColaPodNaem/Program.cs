using ColaPodNaem.Presentation;
using System;

namespace ColaPodNaem
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new avtoparkColiClientyDbContext();
            //...............
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            //.............
            Display display = new Display();
        }
    }
}
