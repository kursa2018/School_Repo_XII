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
            //***********************
            // Fetch() и Delete() -> за кола
            // Процедурите за обработка на клиенти->Add(),Delete(),Fetch(),Update()
            //************************
            Display display = new Display();
        }
    }
}
