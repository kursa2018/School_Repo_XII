using avtopark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            //.......
            Car cars3 = new Car();
            cars3.Model = "Mitsubishi";
            cars3.Color = "YELLOW";
            cars3.YearMaking = new DateTime(1969, 06, 28);
            cars3.PriceNaem = 58.69;
            cars3.Id = "1240";
            context.Cars.Add(cars3);
            //.....
            Client client1 = new Client();
            client1.Name = "Ivan";
            client1.Family = "Ivanov";
            client1.Address = "Kristal";
            client1.Idcard = 523;
            client1.Creditcard = "BG 12598";
            client1.CarOnLoan = "7777";
            context.Clients.Add(client1);
            //.......
            Client client2 = new Client();
            client2.Name = "Georgy";
            client2.Family = "Kostadinov";
            client2.Address = "Pionerska 36";
            client2.Idcard = 526;
            client2.Creditcard = "BG 12598";
            client2.CarOnLoan = "1000";
            context.Clients.Add(client2);
            context.SaveChanges();

        }
    }
}
