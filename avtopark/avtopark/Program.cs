using avtopark.Models;
using System;

namespace avtopark
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new AvtosalovDbContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            Car cars1 = new Car();
            cars1.Model = "BMW";
            cars1.Color = "Black";
            cars1.YearMaking = new DateTime(2010, 02, 28);
            cars1.PriceNaem = 124;
            cars1.Id = "1000";
            context.Cars.Add(cars1);
            //........
            Car cars2 = new Car();
            cars2.Model = "Moskvich";
            cars2.Color = "Green";
            cars2.YearMaking = new DateTime(1978, 02, 28);
            cars2.PriceNaem = 12.36;
            cars2.Id = "7777";
            context.Cars.Add(cars2);
            context.SaveChanges();
            //.....
            
        }
    }
}
