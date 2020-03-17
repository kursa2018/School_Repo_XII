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
            Client c1 = new Client();
            c1.Name = "Иван Иванов";
            c1.Egn = "6608203584";
            c1.Adress = "Кристал 10";
            c1.Tel = "5-12358";
            context.Add(c1);
            context.SaveChanges();
            //..............
            Distributor d1 = new Distributor();
            d1.Name = "Халил Доспатлийски";
            d1.TelContact = "5-6987";
            context.Add(d1);
           
            Product p1 = new Product();
            p1.Number = 123;
            p1.Naimenovanie = "лак за нокти";
            p1.Quantity = 3;
            p1.Price = 2.50;
            p1.Clients = "6608203584";
            p1.Distributors = 1;
            p1.Data = new DateTime(2020, 03, 02);
            context.Add(p1);
            //Добавям 2 данни!!
            Client c2 = new Client();
            c2.Name = "Светлана Петрова";
            c2.Egn = "6608444444";
            c2.Adress = "Съединение 14";
            c2.Tel = "5-5566";
            context.Add(c2);
            context.SaveChanges();
            //..............
            Distributor d2 = new Distributor();
            d2.Name = "Алиш Алишов";
            d2.TelContact = "5-6687";
            context.Add(d2);

            Product p2 = new Product();
            p2.Number = 123;
            p2.Naimenovanie = "лак за нокти";
            p2.Quantity = 3;
            p2.Price = 2.50;
            p2.Clients = "6608444444";
            p2.Distributors = 2;
            p2.Data = new DateTime(2020, 04, 17);
            context.Add(p2);
            context.SaveChanges();
        }
    }
}
