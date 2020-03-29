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
            Car car1 = new Car();
            car1.Id = "AS0147";
            car1.Model = "Ferary";
            car1.Color = "син";
            car1.YearMaking = new DateTime(2010, 01, 25);
            car1.PriceNaem = 25;
            context.Add(car1);
            context.SaveChanges();
            Display display = new Display();
        }
    }
}
