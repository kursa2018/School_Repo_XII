using ColaPodNaem.Model;
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

            // Процедурите за обработка на клиенти->Add(),Delete(),Fetch(),Update()
            Car c1 = new Car();
            c1.Id = "AS1111";
            c1.Model = "Trabant";
            c1.YearMaking = new DateTime(2010, 05, 07);
            c1.Color = "бял";
            c1.PriceNaem = 14.25m;
            context.Add(c1);
            context.SaveChanges();
            //************************
            Car c2 = new Car();
            c2.Id = "AS2111";
            c2.Model = "Lada-Samara-1600";
            c2.YearMaking = new DateTime(2011, 05, 07);
            c2.Color = "оранжева";
            c2.PriceNaem = 142.25m;
            context.Add(c2);
            context.SaveChanges();
            //************************
            Car c3 = new Car();
            c3.Id = "AS3111";
            c3.Model = "Moakvich-58";
            c3.YearMaking = new DateTime(1966, 05, 14);
            c3.Color = "тъмно зелена";
            c3.PriceNaem = 3.25m;
            context.Add(c3);
            context.SaveChanges();
            Display display = new Display();
        }
    }
}
